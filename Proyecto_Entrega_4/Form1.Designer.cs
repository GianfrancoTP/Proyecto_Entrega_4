namespace Proyecto_Entrega_4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MenuLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MaximizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.CloseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.MinimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.MenuButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.RestoreButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.MenuPanel1 = new System.Windows.Forms.Panel();
            this.MenuPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MapButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.RestartButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SaveButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ResultadosButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BitmonsMapButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.OpenAnimation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.CloseAnimation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreButton)).BeginInit();
            this.MenuPanel1.SuspendLayout();
            this.MenuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.TopPanel.Controls.Add(this.MenuLabel);
            this.TopPanel.Controls.Add(this.MaximizeButton);
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Controls.Add(this.MinimizeButton);
            this.TopPanel.Controls.Add(this.MenuButton);
            this.TopPanel.Controls.Add(this.RestoreButton);
            this.CloseAnimation.SetDecoration(this.TopPanel, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this.TopPanel, BunifuAnimatorNS.DecorationType.None);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(969, 60);
            this.TopPanel.TabIndex = 0;
            // 
            // MenuLabel
            // 
            this.MenuLabel.AutoSize = true;
            this.OpenAnimation.SetDecoration(this.MenuLabel, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.MenuLabel, BunifuAnimatorNS.DecorationType.None);
            this.MenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuLabel.ForeColor = System.Drawing.Color.White;
            this.MenuLabel.Location = new System.Drawing.Point(69, 19);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(59, 24);
            this.MenuLabel.TabIndex = 5;
            this.MenuLabel.Text = "Menu";
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseAnimation.SetDecoration(this.MaximizeButton, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this.MaximizeButton, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MaximizeButton.Image")));
            this.MaximizeButton.ImageActive = null;
            this.MaximizeButton.Location = new System.Drawing.Point(879, 14);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(36, 33);
            this.MaximizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MaximizeButton.TabIndex = 1;
            this.MaximizeButton.TabStop = false;
            this.MaximizeButton.Zoom = 10;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseAnimation.SetDecoration(this.CloseButton, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this.CloseButton, BunifuAnimatorNS.DecorationType.None);
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageActive = null;
            this.CloseButton.Location = new System.Drawing.Point(921, 14);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(36, 33);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 4;
            this.CloseButton.TabStop = false;
            this.CloseButton.Zoom = 10;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseAnimation.SetDecoration(this.MinimizeButton, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this.MinimizeButton, BunifuAnimatorNS.DecorationType.None);
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.ImageActive = null;
            this.MinimizeButton.Location = new System.Drawing.Point(837, 14);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(36, 33);
            this.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Zoom = 10;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseAnimation.SetDecoration(this.MenuButton, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this.MenuButton, BunifuAnimatorNS.DecorationType.None);
            this.MenuButton.Image = ((System.Drawing.Image)(resources.GetObject("MenuButton.Image")));
            this.MenuButton.ImageActive = null;
            this.MenuButton.Location = new System.Drawing.Point(18, 14);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(36, 33);
            this.MenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuButton.TabIndex = 0;
            this.MenuButton.TabStop = false;
            this.MenuButton.Zoom = 10;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // RestoreButton
            // 
            this.RestoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestoreButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseAnimation.SetDecoration(this.RestoreButton, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this.RestoreButton, BunifuAnimatorNS.DecorationType.None);
            this.RestoreButton.Image = ((System.Drawing.Image)(resources.GetObject("RestoreButton.Image")));
            this.RestoreButton.ImageActive = null;
            this.RestoreButton.Location = new System.Drawing.Point(879, 14);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(36, 33);
            this.RestoreButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RestoreButton.TabIndex = 3;
            this.RestoreButton.TabStop = false;
            this.RestoreButton.Zoom = 10;
            this.RestoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // MenuPanel1
            // 
            this.MenuPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.MenuPanel1.Controls.Add(this.MenuPanel2);
            this.CloseAnimation.SetDecoration(this.MenuPanel1, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this.MenuPanel1, BunifuAnimatorNS.DecorationType.None);
            this.MenuPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel1.Location = new System.Drawing.Point(0, 60);
            this.MenuPanel1.Name = "MenuPanel1";
            this.MenuPanel1.Size = new System.Drawing.Size(243, 712);
            this.MenuPanel1.TabIndex = 1;
            // 
            // MenuPanel2
            // 
            this.MenuPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuPanel2.BackgroundImage")));
            this.MenuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuPanel2.Controls.Add(this.bunifuFlatButton1);
            this.MenuPanel2.Controls.Add(this.MapButton);
            this.MenuPanel2.Controls.Add(this.RestartButton);
            this.MenuPanel2.Controls.Add(this.SaveButton);
            this.MenuPanel2.Controls.Add(this.ResultadosButton);
            this.MenuPanel2.Controls.Add(this.BitmonsMapButton);
            this.CloseAnimation.SetDecoration(this.MenuPanel2, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this.MenuPanel2, BunifuAnimatorNS.DecorationType.None);
            this.MenuPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.MenuPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.MenuPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.MenuPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.MenuPanel2.Location = new System.Drawing.Point(12, 6);
            this.MenuPanel2.Name = "MenuPanel2";
            this.MenuPanel2.Quality = 10;
            this.MenuPanel2.Size = new System.Drawing.Size(225, 694);
            this.MenuPanel2.TabIndex = 0;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "      Bitmons en el mapa";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenAnimation.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(5, 478);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(202, 59);
            this.bunifuFlatButton1.TabIndex = 7;
            this.bunifuFlatButton1.Text = "      Bitmons en el mapa";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // MapButton
            // 
            this.MapButton.Activecolor = System.Drawing.Color.Transparent;
            this.MapButton.BackColor = System.Drawing.Color.Transparent;
            this.MapButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MapButton.BorderRadius = 0;
            this.MapButton.ButtonText = "      Mapa Bitmonlandia";
            this.MapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenAnimation.SetDecoration(this.MapButton, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.MapButton, BunifuAnimatorNS.DecorationType.None);
            this.MapButton.DisabledColor = System.Drawing.Color.Gray;
            this.MapButton.Iconcolor = System.Drawing.Color.Transparent;
            this.MapButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("MapButton.Iconimage")));
            this.MapButton.Iconimage_right = null;
            this.MapButton.Iconimage_right_Selected = null;
            this.MapButton.Iconimage_Selected = null;
            this.MapButton.IconMarginLeft = 0;
            this.MapButton.IconMarginRight = 0;
            this.MapButton.IconRightVisible = true;
            this.MapButton.IconRightZoom = 0D;
            this.MapButton.IconVisible = true;
            this.MapButton.IconZoom = 50D;
            this.MapButton.IsTab = false;
            this.MapButton.Location = new System.Drawing.Point(5, 78);
            this.MapButton.Name = "MapButton";
            this.MapButton.Normalcolor = System.Drawing.Color.Transparent;
            this.MapButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.MapButton.OnHoverTextColor = System.Drawing.Color.White;
            this.MapButton.selected = false;
            this.MapButton.Size = new System.Drawing.Size(202, 59);
            this.MapButton.TabIndex = 6;
            this.MapButton.Text = "      Mapa Bitmonlandia";
            this.MapButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MapButton.Textcolor = System.Drawing.Color.LightGray;
            this.MapButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // RestartButton
            // 
            this.RestartButton.Activecolor = System.Drawing.Color.Transparent;
            this.RestartButton.BackColor = System.Drawing.Color.Transparent;
            this.RestartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RestartButton.BorderRadius = 0;
            this.RestartButton.ButtonText = "      Empezar nueva                   simulación";
            this.RestartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenAnimation.SetDecoration(this.RestartButton, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.RestartButton, BunifuAnimatorNS.DecorationType.None);
            this.RestartButton.DisabledColor = System.Drawing.Color.Gray;
            this.RestartButton.Iconcolor = System.Drawing.Color.Transparent;
            this.RestartButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("RestartButton.Iconimage")));
            this.RestartButton.Iconimage_right = null;
            this.RestartButton.Iconimage_right_Selected = null;
            this.RestartButton.Iconimage_Selected = null;
            this.RestartButton.IconMarginLeft = 0;
            this.RestartButton.IconMarginRight = 0;
            this.RestartButton.IconRightVisible = true;
            this.RestartButton.IconRightZoom = 0D;
            this.RestartButton.IconVisible = true;
            this.RestartButton.IconZoom = 50D;
            this.RestartButton.IsTab = false;
            this.RestartButton.Location = new System.Drawing.Point(5, 398);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Normalcolor = System.Drawing.Color.Transparent;
            this.RestartButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.RestartButton.OnHoverTextColor = System.Drawing.Color.White;
            this.RestartButton.selected = false;
            this.RestartButton.Size = new System.Drawing.Size(202, 59);
            this.RestartButton.TabIndex = 4;
            this.RestartButton.Text = "      Empezar nueva                   simulación";
            this.RestartButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RestartButton.Textcolor = System.Drawing.Color.LightGray;
            this.RestartButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // SaveButton
            // 
            this.SaveButton.Activecolor = System.Drawing.Color.Transparent;
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveButton.BorderRadius = 0;
            this.SaveButton.ButtonText = "      Guardar datos                     simulación";
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenAnimation.SetDecoration(this.SaveButton, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.SaveButton, BunifuAnimatorNS.DecorationType.None);
            this.SaveButton.DisabledColor = System.Drawing.Color.Gray;
            this.SaveButton.Iconcolor = System.Drawing.Color.Transparent;
            this.SaveButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("SaveButton.Iconimage")));
            this.SaveButton.Iconimage_right = null;
            this.SaveButton.Iconimage_right_Selected = null;
            this.SaveButton.Iconimage_Selected = null;
            this.SaveButton.IconMarginLeft = 0;
            this.SaveButton.IconMarginRight = 0;
            this.SaveButton.IconRightVisible = true;
            this.SaveButton.IconRightZoom = 0D;
            this.SaveButton.IconVisible = true;
            this.SaveButton.IconZoom = 50D;
            this.SaveButton.IsTab = false;
            this.SaveButton.Location = new System.Drawing.Point(5, 318);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Normalcolor = System.Drawing.Color.Transparent;
            this.SaveButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.SaveButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SaveButton.selected = false;
            this.SaveButton.Size = new System.Drawing.Size(202, 59);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "      Guardar datos                     simulación";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.Textcolor = System.Drawing.Color.LightGray;
            this.SaveButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ResultadosButton
            // 
            this.ResultadosButton.Activecolor = System.Drawing.Color.Transparent;
            this.ResultadosButton.BackColor = System.Drawing.Color.Transparent;
            this.ResultadosButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ResultadosButton.BorderRadius = 0;
            this.ResultadosButton.ButtonText = "      Resultado de                      simulación";
            this.ResultadosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenAnimation.SetDecoration(this.ResultadosButton, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.ResultadosButton, BunifuAnimatorNS.DecorationType.None);
            this.ResultadosButton.DisabledColor = System.Drawing.Color.Gray;
            this.ResultadosButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ResultadosButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("ResultadosButton.Iconimage")));
            this.ResultadosButton.Iconimage_right = null;
            this.ResultadosButton.Iconimage_right_Selected = null;
            this.ResultadosButton.Iconimage_Selected = null;
            this.ResultadosButton.IconMarginLeft = 0;
            this.ResultadosButton.IconMarginRight = 0;
            this.ResultadosButton.IconRightVisible = true;
            this.ResultadosButton.IconRightZoom = 0D;
            this.ResultadosButton.IconVisible = true;
            this.ResultadosButton.IconZoom = 50D;
            this.ResultadosButton.IsTab = false;
            this.ResultadosButton.Location = new System.Drawing.Point(5, 238);
            this.ResultadosButton.Name = "ResultadosButton";
            this.ResultadosButton.Normalcolor = System.Drawing.Color.Transparent;
            this.ResultadosButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.ResultadosButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ResultadosButton.selected = false;
            this.ResultadosButton.Size = new System.Drawing.Size(202, 59);
            this.ResultadosButton.TabIndex = 2;
            this.ResultadosButton.Text = "      Resultado de                      simulación";
            this.ResultadosButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResultadosButton.Textcolor = System.Drawing.Color.LightGray;
            this.ResultadosButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BitmonsMapButton
            // 
            this.BitmonsMapButton.Activecolor = System.Drawing.Color.Transparent;
            this.BitmonsMapButton.BackColor = System.Drawing.Color.Transparent;
            this.BitmonsMapButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BitmonsMapButton.BorderRadius = 0;
            this.BitmonsMapButton.ButtonText = "      Bitmons en el mapa";
            this.BitmonsMapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenAnimation.SetDecoration(this.BitmonsMapButton, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.BitmonsMapButton, BunifuAnimatorNS.DecorationType.None);
            this.BitmonsMapButton.DisabledColor = System.Drawing.Color.Gray;
            this.BitmonsMapButton.Iconcolor = System.Drawing.Color.Transparent;
            this.BitmonsMapButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("BitmonsMapButton.Iconimage")));
            this.BitmonsMapButton.Iconimage_right = null;
            this.BitmonsMapButton.Iconimage_right_Selected = null;
            this.BitmonsMapButton.Iconimage_Selected = null;
            this.BitmonsMapButton.IconMarginLeft = 0;
            this.BitmonsMapButton.IconMarginRight = 0;
            this.BitmonsMapButton.IconRightVisible = true;
            this.BitmonsMapButton.IconRightZoom = 0D;
            this.BitmonsMapButton.IconVisible = true;
            this.BitmonsMapButton.IconZoom = 50D;
            this.BitmonsMapButton.IsTab = false;
            this.BitmonsMapButton.Location = new System.Drawing.Point(5, 158);
            this.BitmonsMapButton.Name = "BitmonsMapButton";
            this.BitmonsMapButton.Normalcolor = System.Drawing.Color.Transparent;
            this.BitmonsMapButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.BitmonsMapButton.OnHoverTextColor = System.Drawing.Color.White;
            this.BitmonsMapButton.selected = false;
            this.BitmonsMapButton.Size = new System.Drawing.Size(202, 59);
            this.BitmonsMapButton.TabIndex = 1;
            this.BitmonsMapButton.Text = "      Bitmons en el mapa";
            this.BitmonsMapButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BitmonsMapButton.Textcolor = System.Drawing.Color.LightGray;
            this.BitmonsMapButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // CenterPanel
            // 
            this.CenterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.CloseAnimation.SetDecoration(this.CenterPanel, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this.CenterPanel, BunifuAnimatorNS.DecorationType.None);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(243, 60);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(726, 712);
            this.CenterPanel.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.TopPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.MenuPanel2;
            // 
            // OpenAnimation
            // 
            this.OpenAnimation.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.OpenAnimation.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 20;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.OpenAnimation.DefaultAnimation = animation3;
            // 
            // CloseAnimation
            // 
            this.CloseAnimation.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.CloseAnimation.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 20;
            animation4.Padding = new System.Windows.Forms.Padding(30);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.CloseAnimation.DefaultAnimation = animation4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 772);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.MenuPanel1);
            this.Controls.Add(this.TopPanel);
            this.CloseAnimation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreButton)).EndInit();
            this.MenuPanel1.ResumeLayout(false);
            this.MenuPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private Bunifu.Framework.UI.BunifuImageButton CloseButton;
        private Bunifu.Framework.UI.BunifuImageButton RestoreButton;
        private Bunifu.Framework.UI.BunifuImageButton MinimizeButton;
        private Bunifu.Framework.UI.BunifuImageButton MaximizeButton;
        private Bunifu.Framework.UI.BunifuImageButton MenuButton;
        private System.Windows.Forms.Panel MenuPanel1;
        private System.Windows.Forms.Panel CenterPanel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel MenuLabel;
        private Bunifu.Framework.UI.BunifuGradientPanel MenuPanel2;
        private Bunifu.Framework.UI.BunifuFlatButton MapButton;
        private Bunifu.Framework.UI.BunifuFlatButton RestartButton;
        private Bunifu.Framework.UI.BunifuFlatButton SaveButton;
        private Bunifu.Framework.UI.BunifuFlatButton ResultadosButton;
        private Bunifu.Framework.UI.BunifuFlatButton BitmonsMapButton;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private BunifuAnimatorNS.BunifuTransition OpenAnimation;
        private BunifuAnimatorNS.BunifuTransition CloseAnimation;
    }
}

