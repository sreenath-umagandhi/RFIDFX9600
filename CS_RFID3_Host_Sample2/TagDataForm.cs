using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CS_RFID3_Host_Sample2
{
    public partial class TagDataForm : Form
    {
        private AppForm m_AppForm;

        public TagDataForm(AppForm appForm)
        {
            InitializeComponent();
            m_AppForm = appForm;
        }

        private void TagData_Load(object sender, EventArgs e)
        {
            try
            {
                if (m_AppForm.m_ReaderAPI.IsConnected)
                {
                    ListViewItem item = m_AppForm.inventoryList.SelectedItems[0];

                    tagDataView.Items[0].SubItems.Add(item.SubItems[0].Text);
                    if (item.SubItems.Count > 2)
                    {
                        tagDataView.Items[1].SubItems.Add(item.SubItems[10].Text);
                        
                        
                        
                    }
                }
            }
            catch (Exception ex)
            {
                m_AppForm.functionCallStatusLabel.Text = ex.Message;
            }
        }
    }
}