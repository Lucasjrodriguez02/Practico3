using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Practico3pt2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LNya = new Label();
            LModificar = new Label();
            LDni = new Label();
            LNombre = new Label();
            LApellido = new Label();
            TDni = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            TGuardar = new Button();
            TEliminar = new Button();
            PDatos = new Panel();
            CBMastercard = new CheckBox();
            Ltarjetas = new Label();
            CBVisa = new CheckBox();
            TTelefono = new TextBox();
            CBNaranja = new CheckBox();
            LTelefono = new Label();
            PBPersona = new PictureBox();
            RBVaron = new RadioButton();
            RBMujer = new RadioButton();
            TSalir = new Button();
            PDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBPersona).BeginInit();
            SuspendLayout();
            // 
            // LNya
            // 
            LNya.AutoSize = true;
            LNya.Location = new Point(3, 10);
            LNya.Name = "LNya";
            LNya.Size = new Size(107, 15);
            LNya.TabIndex = 0;
            LNya.Text = "Nombre y Apellido";
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(137, 10);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 1;
            LModificar.Text = "Modificar";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(3, 49);
            LDni.Name = "LDni";
            LDni.Size = new Size(27, 15);
            LDni.TabIndex = 2;
            LDni.Text = "DNI";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(-1, 125);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 3;
            LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(0, 85);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 4;
            LApellido.Text = "Apellido";
            // 
            // TDni
            // 
            TDni.Location = new Point(57, 49);
            TDni.Name = "TDni";
            TDni.Size = new Size(100, 23);
            TDni.TabIndex = 5;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(57, 85);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 6;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(56, 122);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 7;
            // 
            // TGuardar
            // 
            TGuardar.BackColor = SystemColors.ActiveBorder;
            TGuardar.FlatStyle = FlatStyle.Popup;
            TGuardar.Image = Properties.Resources.guardar;
            TGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            TGuardar.Location = new Point(41, 388);
            TGuardar.Name = "TGuardar";
            TGuardar.Size = new Size(107, 65);
            TGuardar.TabIndex = 8;
            TGuardar.Text = "Guardar";
            TGuardar.TextAlign = ContentAlignment.MiddleRight;
            TGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            TGuardar.UseVisualStyleBackColor = false;
            TGuardar.Click += TGuardar_Click;
            // 
            // TEliminar
            // 
            TEliminar.BackColor = SystemColors.ActiveBorder;
            TEliminar.FlatStyle = FlatStyle.Popup;
            TEliminar.Image = Properties.Resources.cancelar1;
            TEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            TEliminar.Location = new Point(201, 388);
            TEliminar.Name = "TEliminar";
            TEliminar.Size = new Size(112, 63);
            TEliminar.TabIndex = 9;
            TEliminar.Text = "Eliminar";
            TEliminar.TextAlign = ContentAlignment.MiddleRight;
            TEliminar.UseVisualStyleBackColor = false;
            TEliminar.Click += TEliminar_Click;
            // 
            // PDatos
            // 
            PDatos.BackColor = Color.LightSteelBlue;
            PDatos.Controls.Add(CBMastercard);
            PDatos.Controls.Add(Ltarjetas);
            PDatos.Controls.Add(CBVisa);
            PDatos.Controls.Add(TTelefono);
            PDatos.Controls.Add(CBNaranja);
            PDatos.Controls.Add(LNya);
            PDatos.Controls.Add(LTelefono);
            PDatos.Controls.Add(LModificar);
            PDatos.Controls.Add(LDni);
            PDatos.Controls.Add(TNombre);
            PDatos.Controls.Add(TDni);
            PDatos.Controls.Add(LNombre);
            PDatos.Controls.Add(TApellido);
            PDatos.Controls.Add(LApellido);
            PDatos.Location = new Point(12, 12);
            PDatos.Name = "PDatos";
            PDatos.Size = new Size(234, 293);
            PDatos.TabIndex = 10;
            // 
            // CBMastercard
            // 
            CBMastercard.AutoSize = true;
            CBMastercard.Location = new Point(119, 270);
            CBMastercard.Name = "CBMastercard";
            CBMastercard.Size = new Size(85, 19);
            CBMastercard.TabIndex = 13;
            CBMastercard.Text = "Mastercard";
            CBMastercard.UseVisualStyleBackColor = true;
            // 
            // Ltarjetas
            // 
            Ltarjetas.AutoSize = true;
            Ltarjetas.Location = new Point(0, 211);
            Ltarjetas.Name = "Ltarjetas";
            Ltarjetas.Size = new Size(113, 15);
            Ltarjetas.TabIndex = 11;
            Ltarjetas.Text = "Tarjetas de Credito : ";
            // 
            // CBVisa
            // 
            CBVisa.AutoSize = true;
            CBVisa.Location = new Point(119, 245);
            CBVisa.Name = "CBVisa";
            CBVisa.Size = new Size(47, 19);
            CBVisa.TabIndex = 12;
            CBVisa.Text = "Visa";
            CBVisa.UseVisualStyleBackColor = true;
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(56, 164);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(100, 23);
            TTelefono.TabIndex = 12;
            // 
            // CBNaranja
            // 
            CBNaranja.AutoSize = true;
            CBNaranja.Location = new Point(119, 220);
            CBNaranja.Name = "CBNaranja";
            CBNaranja.Size = new Size(67, 19);
            CBNaranja.TabIndex = 11;
            CBNaranja.Text = "Naranja";
            CBNaranja.UseVisualStyleBackColor = true;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(-1, 167);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(52, 15);
            LTelefono.TabIndex = 11;
            LTelefono.Text = "Telefono";
            // 
            // PBPersona
            // 
            PBPersona.BorderStyle = BorderStyle.FixedSingle;
            PBPersona.Image = Properties.Resources.icono_varon;
            PBPersona.Location = new Point(405, 74);
            PBPersona.Name = "PBPersona";
            PBPersona.Size = new Size(120, 120);
            PBPersona.SizeMode = PictureBoxSizeMode.CenterImage;
            PBPersona.TabIndex = 11;
            PBPersona.TabStop = false;
            // 
            // RBVaron
            // 
            RBVaron.AutoSize = true;
            RBVaron.Checked = true;
            RBVaron.Location = new Point(405, 232);
            RBVaron.Name = "RBVaron";
            RBVaron.Size = new Size(55, 19);
            RBVaron.TabIndex = 12;
            RBVaron.TabStop = true;
            RBVaron.Text = "Varon";
            RBVaron.UseVisualStyleBackColor = true;
            RBVaron.CheckedChanged += RBVaron_CheckedChanged;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.Location = new Point(469, 232);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(56, 19);
            RBMujer.TabIndex = 13;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = true;
            RBMujer.CheckedChanged += RBMujer_CheckedChanged;
            // 
            // TSalir
            // 
            TSalir.BackColor = SystemColors.ActiveBorder;
            TSalir.FlatStyle = FlatStyle.Popup;
            TSalir.Image = Properties.Resources.salir;
            TSalir.ImageAlign = ContentAlignment.MiddleLeft;
            TSalir.Location = new Point(366, 388);
            TSalir.Name = "TSalir";
            TSalir.Size = new Size(119, 63);
            TSalir.TabIndex = 14;
            TSalir.Text = "Salir";
            TSalir.TextAlign = ContentAlignment.MiddleRight;
            TSalir.UseVisualStyleBackColor = false;
            TSalir.Click += TSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 479);
            Controls.Add(TSalir);
            Controls.Add(RBMujer);
            Controls.Add(RBVaron);
            Controls.Add(PBPersona);
            Controls.Add(PDatos);
            Controls.Add(TEliminar);
            Controls.Add(TGuardar);
            Name = "Form1";
            Text = "Pequeño Formulario";
            PDatos.ResumeLayout(false);
            PDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBPersona).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNya;
        private System.Windows.Forms.Label LModificar;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Button TGuardar;
        private System.Windows.Forms.Button TEliminar;
        private Panel PDatos;
        private Label LTelefono;
        private TextBox TTelefono;
        private Label Ltarjetas;
        private CheckBox CBNaranja;
        private CheckBox CBVisa;
        private CheckBox CBMastercard;
        private PictureBox PBPersona;
        private RadioButton RBVaron;
        private RadioButton RBMujer;
        private Button TSalir;
    }
}