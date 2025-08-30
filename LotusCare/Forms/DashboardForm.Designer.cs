namespace LotusCare.Forms
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalPatients = new System.Windows.Forms.Label();
            this.dgvUpcomingAppointments = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTodaysAppointments = new System.Windows.Forms.Label();
            this.lblNewPatients = new System.Windows.Forms.Label();
            this.Revenue = new System.Windows.Forms.Label();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAppointmentsByDoctor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvLowStock = new System.Windows.Forms.DataGridView();
            this.lstRecentActivity = new System.Windows.Forms.ListBox();
            this.btnNewAppointment = new System.Windows.Forms.Button();
            this.btnNewPatient = new System.Windows.Forms.Button();
            this.btnBilling = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingAppointments)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAppointmentsByDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(36, 13);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(309, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalPatients);
            this.panel1.Location = new System.Drawing.Point(316, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 100);
            this.panel1.TabIndex = 2;
            // 
            // lblTotalPatients
            // 
            this.lblTotalPatients.AutoSize = true;
            this.lblTotalPatients.Location = new System.Drawing.Point(24, 23);
            this.lblTotalPatients.Name = "lblTotalPatients";
            this.lblTotalPatients.Size = new System.Drawing.Size(44, 16);
            this.lblTotalPatients.TabIndex = 0;
            this.lblTotalPatients.Text = "label1";
            // 
            // dgvUpcomingAppointments
            // 
            this.dgvUpcomingAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpcomingAppointments.Location = new System.Drawing.Point(12, 175);
            this.dgvUpcomingAppointments.Name = "dgvUpcomingAppointments";
            this.dgvUpcomingAppointments.RowHeadersWidth = 51;
            this.dgvUpcomingAppointments.RowTemplate.Height = 24;
            this.dgvUpcomingAppointments.Size = new System.Drawing.Size(240, 150);
            this.dgvUpcomingAppointments.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTodaysAppointments);
            this.panel2.Location = new System.Drawing.Point(467, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 100);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblNewPatients);
            this.panel3.Location = new System.Drawing.Point(316, 329);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 100);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Revenue);
            this.panel4.Location = new System.Drawing.Point(467, 329);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(125, 100);
            this.panel4.TabIndex = 6;
            // 
            // lblTodaysAppointments
            // 
            this.lblTodaysAppointments.AutoSize = true;
            this.lblTodaysAppointments.Location = new System.Drawing.Point(35, 33);
            this.lblTodaysAppointments.Name = "lblTodaysAppointments";
            this.lblTodaysAppointments.Size = new System.Drawing.Size(44, 16);
            this.lblTodaysAppointments.TabIndex = 0;
            this.lblTodaysAppointments.Text = "label2";
            // 
            // lblNewPatients
            // 
            this.lblNewPatients.AutoSize = true;
            this.lblNewPatients.Location = new System.Drawing.Point(17, 19);
            this.lblNewPatients.Name = "lblNewPatients";
            this.lblNewPatients.Size = new System.Drawing.Size(44, 16);
            this.lblNewPatients.TabIndex = 0;
            this.lblNewPatients.Text = "label3";
            // 
            // Revenue
            // 
            this.Revenue.AutoSize = true;
            this.Revenue.Location = new System.Drawing.Point(23, 19);
            this.Revenue.Name = "Revenue";
            this.Revenue.Size = new System.Drawing.Size(44, 16);
            this.Revenue.TabIndex = 0;
            this.Revenue.Text = "label4";
            // 
            // chartRevenue
            // 
            chartArea3.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend3);
            this.chartRevenue.Location = new System.Drawing.Point(638, 54);
            this.chartRevenue.Name = "chartRevenue";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartRevenue.Series.Add(series3);
            this.chartRevenue.Size = new System.Drawing.Size(240, 168);
            this.chartRevenue.TabIndex = 7;
            this.chartRevenue.Text = "chart1";
            // 
            // chartAppointmentsByDoctor
            // 
            chartArea4.Name = "ChartArea1";
            this.chartAppointmentsByDoctor.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartAppointmentsByDoctor.Legends.Add(legend4);
            this.chartAppointmentsByDoctor.Location = new System.Drawing.Point(653, 248);
            this.chartAppointmentsByDoctor.Name = "chartAppointmentsByDoctor";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartAppointmentsByDoctor.Series.Add(series4);
            this.chartAppointmentsByDoctor.Size = new System.Drawing.Size(204, 126);
            this.chartAppointmentsByDoctor.TabIndex = 8;
            this.chartAppointmentsByDoctor.Text = "chart1";
            // 
            // dgvLowStock
            // 
            this.dgvLowStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLowStock.Location = new System.Drawing.Point(653, 405);
            this.dgvLowStock.Name = "dgvLowStock";
            this.dgvLowStock.RowHeadersWidth = 51;
            this.dgvLowStock.RowTemplate.Height = 24;
            this.dgvLowStock.Size = new System.Drawing.Size(240, 150);
            this.dgvLowStock.TabIndex = 9;
            // 
            // lstRecentActivity
            // 
            this.lstRecentActivity.FormattingEnabled = true;
            this.lstRecentActivity.ItemHeight = 16;
            this.lstRecentActivity.Location = new System.Drawing.Point(69, 458);
            this.lstRecentActivity.Name = "lstRecentActivity";
            this.lstRecentActivity.Size = new System.Drawing.Size(120, 84);
            this.lstRecentActivity.TabIndex = 10;
            // 
            // btnNewAppointment
            // 
            this.btnNewAppointment.Location = new System.Drawing.Point(91, 577);
            this.btnNewAppointment.Name = "btnNewAppointment";
            this.btnNewAppointment.Size = new System.Drawing.Size(145, 40);
            this.btnNewAppointment.TabIndex = 12;
            this.btnNewAppointment.Text = "New Appointment";
            this.btnNewAppointment.UseVisualStyleBackColor = true;
            // 
            // btnNewPatient
            // 
            this.btnNewPatient.Location = new System.Drawing.Point(269, 577);
            this.btnNewPatient.Name = "btnNewPatient";
            this.btnNewPatient.Size = new System.Drawing.Size(132, 44);
            this.btnNewPatient.TabIndex = 13;
            this.btnNewPatient.Text = "New Patient";
            this.btnNewPatient.UseVisualStyleBackColor = true;
            // 
            // btnBilling
            // 
            this.btnBilling.Location = new System.Drawing.Point(437, 577);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(97, 40);
            this.btnBilling.TabIndex = 14;
            this.btnBilling.Text = "Billing";
            this.btnBilling.UseVisualStyleBackColor = true;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 678);
            this.Controls.Add(this.btnBilling);
            this.Controls.Add(this.btnNewPatient);
            this.Controls.Add(this.btnNewAppointment);
            this.Controls.Add(this.lstRecentActivity);
            this.Controls.Add(this.dgvLowStock);
            this.Controls.Add(this.chartAppointmentsByDoctor);
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvUpcomingAppointments);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dtpDate);
            this.Name = "DashboardForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingAppointments)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAppointmentsByDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalPatients;
        private System.Windows.Forms.DataGridView dgvUpcomingAppointments;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTodaysAppointments;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNewPatients;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Revenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAppointmentsByDoctor;
        private System.Windows.Forms.DataGridView dgvLowStock;
        private System.Windows.Forms.ListBox lstRecentActivity;
        private System.Windows.Forms.Button btnNewAppointment;
        private System.Windows.Forms.Button btnNewPatient;
        private System.Windows.Forms.Button btnBilling;
    }
}