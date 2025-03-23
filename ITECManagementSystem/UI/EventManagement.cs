using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ITECManagementSystem.BL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.UI
{
    public partial class EventManagement : Form
    {
        private readonly EventBL eventBL = new EventBL();

        public EventManagement()
        {
            InitializeComponent();
        }

        private void EventManagement_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadEvents();
        }

        private void LoadComboBoxes()
        {
            try
            {
                List<ItechEdition> editions = eventBL.GetEditions();
                comboBoxEdition.DataSource = editions;
                comboBoxEdition.DisplayMember = "year "; 
                comboBoxEdition.ValueMember = "ItecId";
                List<EventCategory> categories = eventBL.GetEventCategories();
                comboBoxCategory.DataSource = categories;
                comboBoxCategory.DisplayMember = "CategoryName";
                comboBoxCategory.ValueMember = "EventCategoryId";
                List<Committee> committees = eventBL.GetCommittees();
                comboBoxCommittee.DataSource = committees;
                comboBoxCommittee.DisplayMember = "committee_name";
                comboBoxCommittee.ValueMember = "committee_id";
                List<Venue> venues = eventBL.GetVenues();
                comboBoxVenue.DataSource = venues;
                comboBoxVenue.DisplayMember = "VenueName";
                comboBoxVenue.ValueMember = "VenueId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dropdown data: " + ex.Message);
            }
        }

        private void LoadEvents()
        {
            try
            {
                List<ItecEvent> events = eventBL.GetEvents();
                dataGridViewEvents.DataSource = events;
                dataGridViewEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading events: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ItecEvent newEvent = new ItecEvent
                {
                    ItecId = Convert.ToInt32(comboBoxEdition.SelectedValue),
                    EventName = txtEventName.Text.Trim(),
                    EventCategoryId = Convert.ToInt32(comboBoxCategory.SelectedValue),
                    Description = txtDescription.Text.Trim(),
                    EventDate = dateTimePickerEventDate.Value,
                    VenueId = Convert.ToInt32(comboBoxVenue.SelectedValue),
                    CommitteeId = Convert.ToInt32(comboBoxCommittee.SelectedValue)
                };

                if (eventBL.AddEvent(newEvent))
                {
                    MessageBox.Show("Event added successfully!");
                    LoadEvents();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to add event.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding event: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewEvents.SelectedRows.Count > 0)
            {
                try
                {
                    int eventId = Convert.ToInt32(dataGridViewEvents.SelectedRows[0].Cells["EventId"].Value);
                    ItecEvent updatedEvent = new ItecEvent
                    {
                        EventId = eventId,
                        ItecId = Convert.ToInt32(comboBoxEdition.SelectedValue),
                        EventName = txtEventName.Text.Trim(),
                        EventCategoryId = Convert.ToInt32(comboBoxCategory.SelectedValue),
                        Description = txtDescription.Text.Trim(),
                        EventDate = dateTimePickerEventDate.Value,
                        VenueId = Convert.ToInt32(comboBoxVenue.SelectedValue),
                        CommitteeId = Convert.ToInt32(comboBoxCommittee.SelectedValue)
                    };

                    if (eventBL.UpdateEvent(updatedEvent))
                    {
                        MessageBox.Show("Event updated successfully!");
                        LoadEvents();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update event.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating event: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an event to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEvents.SelectedRows.Count > 0)
            {
                try
                {
                    int eventId = Convert.ToInt32(dataGridViewEvents.SelectedRows[0].Cells["EventId"].Value);
                    if (eventBL.DeleteEvent(eventId))
                    {
                        MessageBox.Show("Event deleted successfully!");
                        LoadEvents();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete event.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting event: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an event to delete.");
            }
        }

        private void dataGridViewEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ItecEvent selectedEvent = (ItecEvent)dataGridViewEvents.Rows[e.RowIndex].DataBoundItem;
                comboBoxEdition.SelectedValue = selectedEvent.ItecId;
                txtEventName.Text = selectedEvent.EventName;
                comboBoxCategory.SelectedValue = selectedEvent.EventCategoryId;
                txtDescription.Text = selectedEvent.Description;
                dateTimePickerEventDate.Value = selectedEvent.EventDate;
                comboBoxVenue.SelectedValue = selectedEvent.VenueId;
                comboBoxCommittee.SelectedValue = selectedEvent.CommitteeId;
            }
        }

        private void ClearFields()
        {
            txtEventName.Text = "";
            txtDescription.Text = "";
            dateTimePickerEventDate.Value = DateTime.Now;
        }
    }
}
