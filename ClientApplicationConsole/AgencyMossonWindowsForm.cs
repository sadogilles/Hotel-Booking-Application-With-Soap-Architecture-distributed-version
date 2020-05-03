using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplicationConsole
{
    public partial class AgencyMossonWindowsForm : Form
    {
        //service for hotel consultation
        AgencyMossonServiceRef.AgencyWebServiceSoapClient mosson = new AgencyMossonServiceRef.AgencyWebServiceSoapClient();
        //service for hotel booking
        AgencyMossonBookingServiceRef.AgencyBookingWebServiceSoap mossonBooking = new AgencyMossonBookingServiceRef.AgencyBookingWebServiceSoapClient();

        AgencyMossonServiceRef.Hotel[] hotels;
        int numberOfClick = 1;
        AgencyMossonServiceRef.Room[] rooms;

        ClientBookingInformation client;

       
        public AgencyMossonWindowsForm()
        {
            InitializeComponent();
            //During initialisation only the 2 primary buttons are visible (find hotel and find all hotel)
            notification.Visible = true;
            tableHotelInformation.Visible = false;
            listHotelGrid.Visible = false;
            ClientInformationLayoutPanel.Visible = false;
            roomDataGridView.Visible = false;
            notification.Text = "Notification Here!";

            hotels = mosson.getHotel();
            client = new ClientBookingInformation();

        }

        private void listHotelButton_Click(object sender, EventArgs e)
        {
            notification.Visible = true;
            listHotelGrid.Visible = true;
            tableHotelInformation.Visible = false;
            ClientInformationLayoutPanel.Visible = false;
            roomDataGridView.Visible = false;

            notification.Text = "All Hotel Found!";

            hotels = mosson.getHotel();

            listHotelGrid.DataSource = null;
            listHotelGrid.Rows.Clear();


            foreach (AgencyMossonServiceRef.Hotel h in hotels)
            {

                //contains the number of rows           
                int row = listHotelGrid.Rows.Add();

                //load values from service
                listHotelGrid["name", row].Value = h.Name;
                listHotelGrid["numberofstars", row].Value = h.Rating.ToString();
                listHotelGrid["numberofbed", row].Value = h.NumberOfBed.ToString();
                listHotelGrid["address", row].Value = h.Address.ToString();
                listHotelGrid["phonenumber", row].Value = h.PhoneNumber.ToString();
                listHotelGrid["town", row].Value = h.Town.ToString();
                listHotelGrid["country", row].Value = h.Country.ToString();
                //console.writeline("hotel rating!");
                //console.writeline(h.Rating);

                List<int> prices = new List<int>();

                //compute price
                foreach (AgencyMossonServiceRef.Room r in h.Rooms)
                {

                    prices.Add(r.Price);

                }

                var minPrice = prices.Min();
                var maxPrice = prices.Max();

                String priceRange = minPrice.ToString() + "-" + maxPrice.ToString();

                listHotelGrid["priceRange", row].Value = priceRange;

            }

            numberOfClick++;

        }

        //click to find an hotel
        private void findHotelButton_Click(object sender, EventArgs e)
        {

            notification.Visible = true;
            tableHotelInformation.Visible = true;

            listHotelGrid.Visible = false;
            roomDataGridView.Visible = false;
            ClientInformationLayoutPanel.Visible = false;
            notification.Text = "Enter Your Search criteria!";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            notification.Visible = true;
            listHotelGrid.Visible = true;
            tableHotelInformation.Visible = false;
            ClientInformationLayoutPanel.Visible = false;
            roomDataGridView.Visible = false;

            notification.Text = "Hotel Found!";
            //check for empty field
            if (String.IsNullOrEmpty(townTextBox.Text) || String.IsNullOrEmpty(ArrivalDateTextBox.Text) || String.IsNullOrEmpty(depatureDateTextBox.Text) || String.IsNullOrEmpty(minimumPriceTextBox.Text) || String.IsNullOrEmpty(maximumPriceTextBox.Text) || String.IsNullOrEmpty(numberOfStarsTextBox.Text) || String.IsNullOrEmpty(numberOfPersonToHostTextBox.Text))
            {
                notification.Text = "Some Field are empty!";

                listHotelGrid.Visible = false;
                tableHotelInformation.Visible = true;

            }
            else
            {
                client.HotelTown = townTextBox.Text;
                client.ArrivalDate = ArrivalDateTextBox.Text;
                client.DepartureDate = depatureDateTextBox.Text;
                client.MinPrice = Int32.Parse(minimumPriceTextBox.Text);
                client.MaxPrice = Int32.Parse(maximumPriceTextBox.Text);
                client.NumberOfStars = Int32.Parse(numberOfStarsTextBox.Text);
                client.NumberOfPersonToHost = Int32.Parse(numberOfPersonToHostTextBox.Text);
                client.NumberOfStars = Int32.Parse(numberOfStarsTextBox.Text);

                //for simplicity consider we consider only townName,min price , max price and number of stars
                hotels = mosson.searchhotel(client.HotelTown.ToLower(), client.MinPrice, client.MaxPrice, client.NumberOfStars);

               // foreach (HotelBookingServiceReference.Hotel item in hotels) Console.WriteLine(item);

                
                //clear the grid
                listHotelGrid.DataSource = null;
                listHotelGrid.Rows.Clear();

                //populate grid with hotels found
                foreach (AgencyMossonServiceRef.Hotel h in hotels)
                {
                    //contains the number of rows
                    int row = listHotelGrid.Rows.Add();

                    //load values from service
                    listHotelGrid["name", row].Value = h.Name;
                    listHotelGrid["numberOfStars", row].Value = h.Rating.ToString();
                    listHotelGrid["numberOfBed", row].Value = h.NumberOfBed.ToString();
                    listHotelGrid["address", row].Value = h.Address.ToString();
                    listHotelGrid["phoneNumber", row].Value = h.PhoneNumber.ToString();
                    listHotelGrid["town", row].Value = h.Town.ToString();
                    listHotelGrid["country", row].Value = h.Country.ToString();
                    listHotelGrid["chooseHotel", row].Value = submitButton;

                    List<int> prices = new List<int>();

                    //compute price
                    foreach (AgencyMossonServiceRef.Room r in h.Rooms)
                    {

                        prices.Add(r.Price);

                    }

                    var minPrice = prices.Min();
                    var maxPrice = prices.Max();

                    String priceRange = minPrice.ToString() + "-" + maxPrice.ToString();

                    listHotelGrid["priceRange", row].Value = priceRange;
                }
            }
        }

        private void listHotelGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //set room pane to foreground
            roomDataGridView.Visible = true;
            //hide the other panels
            tableHotelInformation.Visible = false;
            listHotelGrid.Visible = false;
            tableHotelInformation.Visible = false;
            ClientInformationLayoutPanel.Visible = false;
            notification.Visible = false;


            if (e.ColumnIndex == 8)

            {
                //load the rooms
                if (listHotelGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    listHotelGrid.CurrentRow.Selected = true;
                    //Console.WriteLine(listHotelGrid.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString());
                    //get the hotel name
                    client.HotelName = listHotelGrid.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                    rooms = mosson.getRoomFromHotel(client.HotelName); //get the room from the service

                    //clear grid 
                    roomDataGridView.DataSource = null;
                    roomDataGridView.Rows.Clear();

                    // the rooms to roomgrid
                    foreach (AgencyMossonServiceRef.Room room in rooms)
                    {
                        int row = roomDataGridView.Rows.Add();
                        roomDataGridView["roomId", row].Value = room.Id;
                        roomDataGridView["roomPrice", row].Value = room.Price;
                        roomDataGridView["roomNumberOfBed", row].Value = room.NumberOfBed;
                        roomDataGridView["roomCapacity", row].Value = room.Capacity;
                        roomDataGridView["roomStatus", row].Value = room.State;
                    }
                }

                //set notification visible
                notification.Visible = true;
                notification.Text = "Choose a Room!";
            }
        }

        private void roomDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (roomDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    roomDataGridView.CurrentRow.Selected = true;
                    client.RoomId = Int32.Parse(roomDataGridView.Rows[e.RowIndex].Cells["roomId"].FormattedValue.ToString());
                }
            }
            else
            {
                notification.Text = "Click a Button";
            }

            roomDataGridView.Visible = false;
            ClientInformationLayoutPanel.Visible = true;
            notification.Text = "Enter your Credential To Book Room";

        }
        //booking done by the second webservice
        private void submitClientInformation_Click(object sender, EventArgs e)
        {

            //check if fill isnot empty
            if (String.IsNullOrEmpty(clientFirstNameTextBox.Text) || String.IsNullOrEmpty(clientLastNameTextBox.Text) || String.IsNullOrEmpty(clientCardInformationTextBox.Text))
            {
                notification.Text = "Some Field are Empty!";
                return;


            }
            else
            {
                //do nothing
            }


            //make a booking with client credential
            String respond = mossonBooking.doBooking(client.HotelName,client.RoomId,client.ClientFirstName, client.ClientLastName, client.ClientCardInfo);
           
            notification.Visible = true;

            notification.Text = respond;
            //hide notification panel
            var timer = new Timer();
            timer.Interval = 3000;

            timer.Tick += (s, d) => {
                notification.Visible = false;
                timer.Stop();
            };

            timer.Start();


            tableHotelInformation.Visible = false;
            listHotelGrid.Visible = false;
            ClientInformationLayoutPanel.Visible = false;
            roomDataGridView.Visible = false;
        }

        private void AgencyMossonWindowsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
