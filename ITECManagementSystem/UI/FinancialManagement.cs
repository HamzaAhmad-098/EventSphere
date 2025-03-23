using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ITECManagementSystem.BL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem
{
    public partial class FinancialManagement : Form
    {
        FinanceBL financeBL = new FinanceBL();
        EntitySelectionBL entitySelectionBL = new EntitySelectionBL();

        public FinancialManagement()
        {
            InitializeComponent();
        }
        private void FinancialManagement_Load(object sender, EventArgs e)
        {
            LoadItecEditions();
            LoadEvents();
            LoadTransactionTypes();
            LoadToEntityTypes();
            LoadFromEntityTypes();
            comboBoxFromEntityType.SelectedIndexChanged += ComboBoxFromEntityType_SelectedIndexChanged;
            comboBoxToEntityType.SelectedIndexChanged += ComboBoxToEntityType_SelectedIndexChanged;
        }

        private void LoadItecEditions()
        {
            using (var conn = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;port=3306;database=MidProjectDb;user=root;password=Vat02842@Vat02842@;"))
            {
                conn.Open();
                string query = "SELECT itec_id, year FROM itec_editions";
                var adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(query, conn);
                var dt = new System.Data.DataTable();
                adapter.Fill(dt);
                comboBoxItec.DataSource = dt;
                comboBoxItec.DisplayMember = "year";
                comboBoxItec.ValueMember = "itec_id";
            }
        }

        private void LoadEvents()
        {
            using (var conn = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;port=3306;database=MidProjectDb;user=root;password=Vat02842@Vat02842@;"))
            {
                conn.Open();
                string query = "SELECT event_id, event_name FROM itec_events";
                var adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(query, conn);
                var dt = new System.Data.DataTable();
                adapter.Fill(dt);
                comboBoxEvent.DataSource = dt;
                comboBoxEvent.DisplayMember = "event_name";
                comboBoxEvent.ValueMember = "event_id";
            }
        }
        private void ComboBoxFromEntityType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFromEntityType.SelectedItem == null)
                return;
            var selectedKvp = (KeyValuePair<int, string>)comboBoxFromEntityType.SelectedItem;
            string entityType = selectedKvp.Value;

            try
            {
                List<KeyValuePair<int, string>> entities = entitySelectionBL.GetEntitiesByType(entityType);
                comboBoxFromEntity.DataSource = new BindingSource(entities, null);
                comboBoxFromEntity.DisplayMember = "Value";
                comboBoxFromEntity.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading From entities: " + ex.Message);
            }
        }

        private void ComboBoxToEntityType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxToEntityType.SelectedItem == null)
                return;

            var selectedKvp = (KeyValuePair<int, string>)comboBoxToEntityType.SelectedItem;
            string entityType = selectedKvp.Value;

            try
            {
                List<KeyValuePair<int, string>> entities = entitySelectionBL.GetEntitiesByType(entityType);
                comboBoxToEntity.DataSource = new BindingSource(entities, null);
                comboBoxToEntity.DisplayMember = "Value";
                comboBoxToEntity.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading To entities: " + ex.Message);
            }
        }
        private void btnRecordTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                FinanceTransaction txn = new FinanceTransaction
                {
                    ItecId = Convert.ToInt32(comboBoxItec.SelectedValue),
                    EventId = Convert.ToInt32(comboBoxEvent.SelectedValue),
                    TypeId = ((KeyValuePair<int, string>)comboBoxType.SelectedItem).Key, // Fixed line
                    Amount = Convert.ToDecimal(txtAmount.Text),
                    FromEntityType = ((KeyValuePair<int, string>)comboBoxFromEntityType.SelectedItem).Value,
                    FromEntityId = Convert.ToInt32(comboBoxFromEntity.SelectedValue),
                    ToEntityType = ((KeyValuePair<int, string>)comboBoxToEntityType.SelectedItem).Value,
                    ToEntityId = Convert.ToInt32(comboBoxToEntity.SelectedValue),
                    Description = txtTransactionDescription.Text,
                    DateRecorded = dateTimePickerDateRecorded.Value
                };

                if (financeBL.RecordTransaction(txn))
                {
                    MessageBox.Show("Transaction recorded successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error recording transaction: " + ex.Message);
            }
        }
        private readonly LookupBL lookupBL = new LookupBL();
        private void LoadFromEntityTypes()
        {
            try
            {
                var fromTypes = lookupBL.GetLookupValues("EntityTypes");
                comboBoxFromEntityType.DataSource = new BindingSource(fromTypes, null);
                comboBoxFromEntityType.DisplayMember = "Value";
                comboBoxFromEntityType.ValueMember = "Key";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error loading From entity types: " + ex.Message);
            }
        }

        private void LoadTransactionTypes()
        {
            try
            {
                var types = lookupBL.GetLookupValues("FinanceTypes");
                comboBoxType.DataSource = new BindingSource(types, null);
                comboBoxType.DisplayMember = "Value";
                comboBoxType.ValueMember = "Key";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error loading transaction types: " + ex.Message);
            }
        }

        private void LoadToEntityTypes()
        {
            try
            {
                var toTypes = lookupBL.GetLookupValues("EntityTypes");
                comboBoxToEntityType.DataSource = new BindingSource(toTypes, null);
                comboBoxToEntityType.DisplayMember = "Value";
                comboBoxToEntityType.ValueMember = "Key";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error loading To entity types: " + ex.Message);
            }
        }
    }
}
