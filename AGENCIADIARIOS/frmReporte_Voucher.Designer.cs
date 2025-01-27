namespace AGENCIADIARIOS
{
    partial class frmReporte_Voucher
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
			this.components = new System.ComponentModel.Container();
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			this.sPREPORTEVOUCHERBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bD_VENTA_DIARIOSDataSet = new AGENCIADIARIOS.BD_VENTA_DIARIOSDataSet();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.sP_REPORTE_VOUCHERTableAdapter = new AGENCIADIARIOS.BD_VENTA_DIARIOSDataSetTableAdapters.SP_REPORTE_VOUCHERTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.sPREPORTEVOUCHERBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bD_VENTA_DIARIOSDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// sPREPORTEVOUCHERBindingSource
			// 
			this.sPREPORTEVOUCHERBindingSource.DataMember = "SP_REPORTE_VOUCHER";
			this.sPREPORTEVOUCHERBindingSource.DataSource = this.bD_VENTA_DIARIOSDataSet;
			// 
			// bD_VENTA_DIARIOSDataSet
			// 
			this.bD_VENTA_DIARIOSDataSet.DataSetName = "BD_VENTA_DIARIOSDataSet";
			this.bD_VENTA_DIARIOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.reportViewer1.DocumentMapWidth = 9;
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.sPREPORTEVOUCHERBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "AGENCIADIARIOS.Report1.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(670, 652);
			this.reportViewer1.TabIndex = 3;
			// 
			// sP_REPORTE_VOUCHERTableAdapter
			// 
			this.sP_REPORTE_VOUCHERTableAdapter.ClearBeforeFill = true;
			// 
			// frmReporte_Voucher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(670, 652);
			this.Controls.Add(this.reportViewer1);
			this.Name = "frmReporte_Voucher";
			this.Text = "frmReporte_Voucher";
			this.Load += new System.EventHandler(this.frmReporte_Voucher_Load);
			((System.ComponentModel.ISupportInitialize)(this.sPREPORTEVOUCHERBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bD_VENTA_DIARIOSDataSet)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPREPORTEVOUCHERBindingSource;
        private BD_VENTA_DIARIOSDataSet bD_VENTA_DIARIOSDataSet;
        private BD_VENTA_DIARIOSDataSetTableAdapters.SP_REPORTE_VOUCHERTableAdapter sP_REPORTE_VOUCHERTableAdapter;
    }
}