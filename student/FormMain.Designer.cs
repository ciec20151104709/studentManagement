namespace student
{
    partial class FormMain
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCharge = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.ColCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExitSystem = new System.Windows.Forms.Button();
            this.btnalteruserpass = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbusername = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCharge);
            this.groupBox2.Controls.Add(this.btnAddCar);
            this.groupBox2.Controls.Add(this.dgvInfo);
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 435);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "学生信息";
            // 
            // btnCharge
            // 
            this.btnCharge.Location = new System.Drawing.Point(594, 226);
            this.btnCharge.Name = "btnCharge";
            this.btnCharge.Size = new System.Drawing.Size(113, 23);
            this.btnCharge.TabIndex = 2;
            this.btnCharge.Text = "结算停车费";
            this.btnCharge.UseVisualStyleBackColor = true;
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(594, 85);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(113, 23);
            this.btnAddCar.TabIndex = 1;
            this.btnAddCar.Text = "添加学生";
            this.btnAddCar.UseVisualStyleBackColor = true;
            // 
            // dgvInfo
            // 
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCount,
            this.ColNum,
            this.ColType,
            this.ColArrival,
            this.Colplace});
            this.dgvInfo.Location = new System.Drawing.Point(6, 34);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowTemplate.Height = 27;
            this.dgvInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfo.Size = new System.Drawing.Size(551, 305);
            this.dgvInfo.TabIndex = 0;
            // 
            // ColCount
            // 
            this.ColCount.DataPropertyName = "colcount";
            this.ColCount.HeaderText = "编号";
            this.ColCount.Name = "ColCount";
            // 
            // ColNum
            // 
            this.ColNum.DataPropertyName = "colnum";
            this.ColNum.HeaderText = "车牌号";
            this.ColNum.Name = "ColNum";
            // 
            // ColType
            // 
            this.ColType.DataPropertyName = "coltype";
            this.ColType.HeaderText = "车辆类型";
            this.ColType.Name = "ColType";
            // 
            // ColArrival
            // 
            this.ColArrival.DataPropertyName = "colarrival";
            this.ColArrival.HeaderText = "到达时间";
            this.ColArrival.Name = "ColArrival";
            // 
            // Colplace
            // 
            this.Colplace.DataPropertyName = "colcount";
            this.Colplace.HeaderText = "位置";
            this.Colplace.Name = "Colplace";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "你好";
            // 
            // btnExitSystem
            // 
            this.btnExitSystem.Location = new System.Drawing.Point(703, 12);
            this.btnExitSystem.Name = "btnExitSystem";
            this.btnExitSystem.Size = new System.Drawing.Size(96, 54);
            this.btnExitSystem.TabIndex = 14;
            this.btnExitSystem.Text = "退出系统";
            this.btnExitSystem.UseVisualStyleBackColor = true;
            // 
            // btnalteruserpass
            // 
            this.btnalteruserpass.Location = new System.Drawing.Point(552, 12);
            this.btnalteruserpass.Name = "btnalteruserpass";
            this.btnalteruserpass.Size = new System.Drawing.Size(91, 49);
            this.btnalteruserpass.TabIndex = 13;
            this.btnalteruserpass.Text = "修改密码";
            this.btnalteruserpass.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "欢迎使用内蒙古师范大学学生管理系统！";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbusername.Location = new System.Drawing.Point(132, -13);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(0, 24);
            this.lbusername.TabIndex = 11;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 529);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExitSystem);
            this.Controls.Add(this.btnalteruserpass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbusername);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCharge;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExitSystem;
        private System.Windows.Forms.Button btnalteruserpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbusername;
    }
}