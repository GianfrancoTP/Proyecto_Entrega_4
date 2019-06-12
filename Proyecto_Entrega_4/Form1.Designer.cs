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
            BunifuAnimatorNS.Animation animation12 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation11 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MenuLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MaximizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.CloseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.MinimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.MenuButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.RestoreButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.MenuPanel1 = new System.Windows.Forms.Panel();
            this.MenuPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MapButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.RestartButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SaveButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ResultadosButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BitmonsMapButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CenterPanel1 = new System.Windows.Forms.Panel();
            this.CenterPanel2 = new System.Windows.Forms.Panel();
            this.NextMonthButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MonthNumberLabel = new System.Windows.Forms.Label();
            this.MapSizeLabel = new System.Windows.Forms.Label();
            this.Map1Button = new Bunifu.Framework.UI.BunifuTileButton();
            this.Map3Button = new Bunifu.Framework.UI.BunifuTileButton();
            this.Map2Button = new Bunifu.Framework.UI.BunifuTileButton();
            this.MapPanel = new System.Windows.Forms.TableLayoutPanel();
            this.InfoMonthPanel = new System.Windows.Forms.Panel();
            this.MonthNumberBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.InfoMonthLabel = new System.Windows.Forms.Label();
            this.BitmonsMapLabel = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ElipseForm1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipseMenu2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.OpenAnimation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.CloseAnimation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.ElipseInfoMonth = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipseMap1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipseMap2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipseMap3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipseCenterPanel2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipseNextMonth = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ResultadosLabel = new System.Windows.Forms.Label();
            this.TitleMonthInfoLabel = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreButton)).BeginInit();
            this.MenuPanel1.SuspendLayout();
            this.MenuPanel2.SuspendLayout();
            this.CenterPanel1.SuspendLayout();
            this.CenterPanel2.SuspendLayout();
            this.InfoMonthPanel.SuspendLayout();
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
            this.MenuPanel2.Controls.Add(this.button1);
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
            // button1
            // 
            this.OpenAnimation.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.Location = new System.Drawing.Point(6, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.NextMonthButton_Click);
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
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Transparent;
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
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Gray;
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
            this.MapButton.DisabledColor = System.Drawing.Color.Transparent;
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
            this.MapButton.Textcolor = System.Drawing.Color.Gray;
            this.MapButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapButton.Click += new System.EventHandler(this.MapButton_Click);
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
            this.RestartButton.DisabledColor = System.Drawing.Color.Transparent;
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
            this.RestartButton.Textcolor = System.Drawing.Color.Gray;
            this.RestartButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
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
            this.SaveButton.DisabledColor = System.Drawing.Color.Transparent;
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
            this.SaveButton.Textcolor = System.Drawing.Color.Gray;
            this.SaveButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
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
            this.ResultadosButton.DisabledColor = System.Drawing.Color.Transparent;
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
            this.ResultadosButton.Textcolor = System.Drawing.Color.Gray;
            this.ResultadosButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadosButton.Click += new System.EventHandler(this.ResultadosButton_Click);
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
            this.BitmonsMapButton.DisabledColor = System.Drawing.Color.Transparent;
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
            this.BitmonsMapButton.Textcolor = System.Drawing.Color.Gray;
            this.BitmonsMapButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BitmonsMapButton.Click += new System.EventHandler(this.BitmonsMapButton_Click);
            // 
            // CenterPanel1
            // 
            this.CenterPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.CenterPanel1.Controls.Add(this.CenterPanel2);
            this.CenterPanel1.Controls.Add(this.InfoMonthPanel);
            this.CloseAnimation.SetDecoration(this.CenterPanel1, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this.CenterPanel1, BunifuAnimatorNS.DecorationType.None);
            this.CenterPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel1.Location = new System.Drawing.Point(243, 60);
            this.CenterPanel1.Name = "CenterPanel1";
            this.CenterPanel1.Size = new System.Drawing.Size(726, 712);
            this.CenterPanel1.TabIndex = 2;
            // 
            // CenterPanel2
            // 
            this.CenterPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CenterPanel2.AutoScroll = true;
            this.CenterPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.CenterPanel2.Controls.Add(this.ResultadosLabel);
            this.CenterPanel2.Controls.Add(this.NextMonthButton);
            this.CenterPanel2.Controls.Add(this.MonthNumberLabel);
            this.CenterPanel2.Controls.Add(this.BitmonsMapLabel);
            this.CenterPanel2.Controls.Add(this.MapSizeLabel);
            this.CenterPanel2.Controls.Add(this.Map1Button);
            this.CenterPanel2.Controls.Add(this.Map3Button);
            this.CenterPanel2.Controls.Add(this.Map2Button);
            this.CenterPanel2.Controls.Add(this.MapPanel);
            this.CloseAnimation.SetDecoration(this.CenterPanel2, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this.CenterPanel2, BunifuAnimatorNS.DecorationType.None);
            this.CenterPanel2.Location = new System.Drawing.Point(6, 6);
            this.CenterPanel2.Name = "CenterPanel2";
            this.CenterPanel2.Size = new System.Drawing.Size(708, 537);
            this.CenterPanel2.TabIndex = 6;
            // 
            // NextMonthButton
            // 
            this.NextMonthButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.NextMonthButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.NextMonthButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextMonthButton.BorderRadius = 0;
            this.NextMonthButton.ButtonText = "Empezar  simulacion";
            this.NextMonthButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenAnimation.SetDecoration(this.NextMonthButton, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.NextMonthButton, BunifuAnimatorNS.DecorationType.None);
            this.NextMonthButton.DisabledColor = System.Drawing.Color.Gray;
            this.NextMonthButton.Iconcolor = System.Drawing.Color.Transparent;
            this.NextMonthButton.Iconimage = null;
            this.NextMonthButton.Iconimage_right = null;
            this.NextMonthButton.Iconimage_right_Selected = null;
            this.NextMonthButton.Iconimage_Selected = null;
            this.NextMonthButton.IconMarginLeft = 0;
            this.NextMonthButton.IconMarginRight = 0;
            this.NextMonthButton.IconRightVisible = true;
            this.NextMonthButton.IconRightZoom = 0D;
            this.NextMonthButton.IconVisible = true;
            this.NextMonthButton.IconZoom = 90D;
            this.NextMonthButton.IsTab = false;
            this.NextMonthButton.Location = new System.Drawing.Point(515, 24);
            this.NextMonthButton.Name = "NextMonthButton";
            this.NextMonthButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.NextMonthButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.NextMonthButton.OnHoverTextColor = System.Drawing.Color.White;
            this.NextMonthButton.selected = false;
            this.NextMonthButton.Size = new System.Drawing.Size(161, 48);
            this.NextMonthButton.TabIndex = 7;
            this.NextMonthButton.Text = "Empezar  simulacion";
            this.NextMonthButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NextMonthButton.Textcolor = System.Drawing.Color.White;
            this.NextMonthButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextMonthButton.Visible = false;
            this.NextMonthButton.Click += new System.EventHandler(this.NextMonthButton_Click);
            // 
            // MonthNumberLabel
            // 
            this.MonthNumberLabel.AutoSize = true;
            this.OpenAnimation.SetDecoration(this.MonthNumberLabel, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.MonthNumberLabel, BunifuAnimatorNS.DecorationType.None);
            this.MonthNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthNumberLabel.ForeColor = System.Drawing.Color.White;
            this.MonthNumberLabel.Location = new System.Drawing.Point(38, 38);
            this.MonthNumberLabel.Name = "MonthNumberLabel";
            this.MonthNumberLabel.Size = new System.Drawing.Size(95, 31);
            this.MonthNumberLabel.TabIndex = 6;
            this.MonthNumberLabel.Text = "Mes: 0";
            this.MonthNumberLabel.Visible = false;
            this.MonthNumberLabel.Click += new System.EventHandler(this.NextMonthButton_Click);
            // 
            // MapSizeLabel
            // 
            this.MapSizeLabel.AutoSize = true;
            this.OpenAnimation.SetDecoration(this.MapSizeLabel, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.MapSizeLabel, BunifuAnimatorNS.DecorationType.None);
            this.MapSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapSizeLabel.ForeColor = System.Drawing.Color.White;
            this.MapSizeLabel.Location = new System.Drawing.Point(158, 142);
            this.MapSizeLabel.Name = "MapSizeLabel";
            this.MapSizeLabel.Size = new System.Drawing.Size(391, 31);
            this.MapSizeLabel.TabIndex = 4;
            this.MapSizeLabel.Text = "Elije las dimensiones del mapa:";
            // 
            // Map1Button
            // 
            this.Map1Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Map1Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Map1Button.color = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Map1Button.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Map1Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseAnimation.SetDecoration(this.Map1Button, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this.Map1Button, BunifuAnimatorNS.DecorationType.None);
            this.Map1Button.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Map1Button.ForeColor = System.Drawing.Color.White;
            this.Map1Button.Image = ((System.Drawing.Image)(resources.GetObject("Map1Button.Image")));
            this.Map1Button.ImagePosition = 20;
            this.Map1Button.ImageZoom = 50;
            this.Map1Button.LabelPosition = 41;
            this.Map1Button.LabelText = "6x6";
            this.Map1Button.Location = new System.Drawing.Point(81, 222);
            this.Map1Button.Margin = new System.Windows.Forms.Padding(6);
            this.Map1Button.Name = "Map1Button";
            this.Map1Button.Size = new System.Drawing.Size(128, 131);
            this.Map1Button.TabIndex = 1;
            this.Map1Button.Click += new System.EventHandler(this.Map1Button_Click);
            // 
            // Map3Button
            // 
            this.Map3Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Map3Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Map3Button.color = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Map3Button.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Map3Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseAnimation.SetDecoration(this.Map3Button, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this.Map3Button, BunifuAnimatorNS.DecorationType.None);
            this.Map3Button.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Map3Button.ForeColor = System.Drawing.Color.White;
            this.Map3Button.Image = ((System.Drawing.Image)(resources.GetObject("Map3Button.Image")));
            this.Map3Button.ImagePosition = 20;
            this.Map3Button.ImageZoom = 50;
            this.Map3Button.LabelPosition = 41;
            this.Map3Button.LabelText = "10x10";
            this.Map3Button.Location = new System.Drawing.Point(490, 222);
            this.Map3Button.Margin = new System.Windows.Forms.Padding(6);
            this.Map3Button.Name = "Map3Button";
            this.Map3Button.Size = new System.Drawing.Size(128, 131);
            this.Map3Button.TabIndex = 3;
            this.Map3Button.Click += new System.EventHandler(this.Map3Button_Click);
            // 
            // Map2Button
            // 
            this.Map2Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Map2Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Map2Button.color = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Map2Button.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Map2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseAnimation.SetDecoration(this.Map2Button, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this.Map2Button, BunifuAnimatorNS.DecorationType.None);
            this.Map2Button.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Map2Button.ForeColor = System.Drawing.Color.White;
            this.Map2Button.Image = ((System.Drawing.Image)(resources.GetObject("Map2Button.Image")));
            this.Map2Button.ImagePosition = 20;
            this.Map2Button.ImageZoom = 50;
            this.Map2Button.LabelPosition = 41;
            this.Map2Button.LabelText = "7x7";
            this.Map2Button.Location = new System.Drawing.Point(288, 222);
            this.Map2Button.Margin = new System.Windows.Forms.Padding(6);
            this.Map2Button.Name = "Map2Button";
            this.Map2Button.Size = new System.Drawing.Size(128, 131);
            this.Map2Button.TabIndex = 2;
            this.Map2Button.Click += new System.EventHandler(this.Map2Button_Click);
            // 
            // MapPanel
            // 
            this.MapPanel.ColumnCount = 10;
            this.MapPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MapPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MapPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MapPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MapPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MapPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MapPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MapPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MapPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MapPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.CloseAnimation.SetDecoration(this.MapPanel, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this.MapPanel, BunifuAnimatorNS.DecorationType.None);
            this.MapPanel.Location = new System.Drawing.Point(44, 97);
            this.MapPanel.Name = "MapPanel";
            this.MapPanel.RowCount = 10;
            this.MapPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MapPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MapPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MapPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MapPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MapPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MapPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MapPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MapPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MapPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MapPanel.Size = new System.Drawing.Size(616, 429);
            this.MapPanel.TabIndex = 5;
            this.MapPanel.Visible = false;
            // 
            // InfoMonthPanel
            // 
            this.InfoMonthPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoMonthPanel.AutoScroll = true;
            this.InfoMonthPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.InfoMonthPanel.Controls.Add(this.TitleMonthInfoLabel);
            this.InfoMonthPanel.Controls.Add(this.MonthNumberBox);
            this.InfoMonthPanel.Controls.Add(this.InfoMonthLabel);
            this.CloseAnimation.SetDecoration(this.InfoMonthPanel, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this.InfoMonthPanel, BunifuAnimatorNS.DecorationType.None);
            this.InfoMonthPanel.ForeColor = System.Drawing.Color.Transparent;
            this.InfoMonthPanel.Location = new System.Drawing.Point(6, 549);
            this.InfoMonthPanel.Name = "InfoMonthPanel";
            this.InfoMonthPanel.Size = new System.Drawing.Size(708, 151);
            this.InfoMonthPanel.TabIndex = 0;
            // 
            // MonthNumberBox
            // 
            this.MonthNumberBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CloseAnimation.SetDecoration(this.MonthNumberBox, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this.MonthNumberBox, BunifuAnimatorNS.DecorationType.None);
            this.MonthNumberBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthNumberBox.ForeColor = System.Drawing.Color.White;
            this.MonthNumberBox.HintForeColor = System.Drawing.Color.Empty;
            this.MonthNumberBox.HintText = "Elije cantidad de meses para la simulación";
            this.MonthNumberBox.isPassword = false;
            this.MonthNumberBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.MonthNumberBox.LineIdleColor = System.Drawing.Color.Gray;
            this.MonthNumberBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.MonthNumberBox.LineThickness = 4;
            this.MonthNumberBox.Location = new System.Drawing.Point(139, 74);
            this.MonthNumberBox.Margin = new System.Windows.Forms.Padding(7);
            this.MonthNumberBox.Name = "MonthNumberBox";
            this.MonthNumberBox.Size = new System.Drawing.Size(418, 49);
            this.MonthNumberBox.TabIndex = 2;
            this.MonthNumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MonthNumberBox.Visible = false;
            this.MonthNumberBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BunifuMaterialTextbox1_KeyDown);
            // 
            // InfoMonthLabel
            // 
            this.InfoMonthLabel.AutoSize = true;
            this.OpenAnimation.SetDecoration(this.InfoMonthLabel, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.InfoMonthLabel, BunifuAnimatorNS.DecorationType.None);
            this.InfoMonthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoMonthLabel.ForeColor = System.Drawing.Color.White;
            this.InfoMonthLabel.Location = new System.Drawing.Point(28, 42);
            this.InfoMonthLabel.Name = "InfoMonthLabel";
            this.InfoMonthLabel.Size = new System.Drawing.Size(46, 18);
            this.InfoMonthLabel.TabIndex = 1;
            this.InfoMonthLabel.Text = "label1";
            // 
            // BitmonsMapLabel
            // 
            this.BitmonsMapLabel.AutoSize = true;
            this.OpenAnimation.SetDecoration(this.BitmonsMapLabel, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.BitmonsMapLabel, BunifuAnimatorNS.DecorationType.None);
            this.BitmonsMapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BitmonsMapLabel.ForeColor = System.Drawing.Color.White;
            this.BitmonsMapLabel.Location = new System.Drawing.Point(40, 24);
            this.BitmonsMapLabel.Name = "BitmonsMapLabel";
            this.BitmonsMapLabel.Size = new System.Drawing.Size(60, 24);
            this.BitmonsMapLabel.TabIndex = 0;
            this.BitmonsMapLabel.Text = "label1";
            this.BitmonsMapLabel.Visible = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.TopPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // ElipseForm1
            // 
            this.ElipseForm1.ElipseRadius = 10;
            this.ElipseForm1.TargetControl = this;
            // 
            // ElipseMenu2
            // 
            this.ElipseMenu2.ElipseRadius = 10;
            this.ElipseMenu2.TargetControl = this.MenuPanel2;
            // 
            // OpenAnimation
            // 
            this.OpenAnimation.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.OpenAnimation.Cursor = null;
            animation12.AnimateOnlyDifferences = true;
            animation12.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.BlindCoeff")));
            animation12.LeafCoeff = 1F;
            animation12.MaxTime = 1F;
            animation12.MinTime = 0F;
            animation12.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicCoeff")));
            animation12.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicShift")));
            animation12.MosaicSize = 0;
            animation12.Padding = new System.Windows.Forms.Padding(0);
            animation12.RotateCoeff = 0F;
            animation12.RotateLimit = 0F;
            animation12.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.ScaleCoeff")));
            animation12.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.SlideCoeff")));
            animation12.TimeCoeff = 0F;
            animation12.TransparencyCoeff = 0F;
            this.OpenAnimation.DefaultAnimation = animation12;
            // 
            // CloseAnimation
            // 
            this.CloseAnimation.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.CloseAnimation.Cursor = null;
            animation11.AnimateOnlyDifferences = true;
            animation11.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.BlindCoeff")));
            animation11.LeafCoeff = 1F;
            animation11.MaxTime = 1F;
            animation11.MinTime = 0F;
            animation11.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicCoeff")));
            animation11.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicShift")));
            animation11.MosaicSize = 0;
            animation11.Padding = new System.Windows.Forms.Padding(0);
            animation11.RotateCoeff = 0F;
            animation11.RotateLimit = 0F;
            animation11.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.ScaleCoeff")));
            animation11.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.SlideCoeff")));
            animation11.TimeCoeff = 0F;
            animation11.TransparencyCoeff = 0F;
            this.CloseAnimation.DefaultAnimation = animation11;
            // 
            // ElipseInfoMonth
            // 
            this.ElipseInfoMonth.ElipseRadius = 10;
            this.ElipseInfoMonth.TargetControl = this.InfoMonthPanel;
            // 
            // ElipseMap1
            // 
            this.ElipseMap1.ElipseRadius = 10;
            this.ElipseMap1.TargetControl = this.Map1Button;
            // 
            // ElipseMap2
            // 
            this.ElipseMap2.ElipseRadius = 10;
            this.ElipseMap2.TargetControl = this.Map2Button;
            // 
            // ElipseMap3
            // 
            this.ElipseMap3.ElipseRadius = 10;
            this.ElipseMap3.TargetControl = this.Map3Button;
            // 
            // ElipseCenterPanel2
            // 
            this.ElipseCenterPanel2.ElipseRadius = 10;
            this.ElipseCenterPanel2.TargetControl = this.CenterPanel2;
            // 
            // ElipseNextMonth
            // 
            this.ElipseNextMonth.ElipseRadius = 10;
            this.ElipseNextMonth.TargetControl = this.NextMonthButton;
            // 
            // ResultadosLabel
            // 
            this.ResultadosLabel.AutoSize = true;
            this.OpenAnimation.SetDecoration(this.ResultadosLabel, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.ResultadosLabel, BunifuAnimatorNS.DecorationType.None);
            this.ResultadosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadosLabel.ForeColor = System.Drawing.Color.White;
            this.ResultadosLabel.Location = new System.Drawing.Point(40, 24);
            this.ResultadosLabel.Name = "ResultadosLabel";
            this.ResultadosLabel.Size = new System.Drawing.Size(60, 24);
            this.ResultadosLabel.TabIndex = 6;
            this.ResultadosLabel.Text = "label1";
            this.ResultadosLabel.Visible = false;
            // 
            // TitleMonthInfoLabel
            // 
            this.TitleMonthInfoLabel.AutoSize = true;
            this.OpenAnimation.SetDecoration(this.TitleMonthInfoLabel, BunifuAnimatorNS.DecorationType.None);
            this.CloseAnimation.SetDecoration(this.TitleMonthInfoLabel, BunifuAnimatorNS.DecorationType.None);
            this.TitleMonthInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleMonthInfoLabel.Location = new System.Drawing.Point(206, 11);
            this.TitleMonthInfoLabel.Name = "TitleMonthInfoLabel";
            this.TitleMonthInfoLabel.Size = new System.Drawing.Size(281, 24);
            this.TitleMonthInfoLabel.TabIndex = 3;
            this.TitleMonthInfoLabel.Text = "Informacion sobre el actual mes:";
            this.TitleMonthInfoLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 772);
            this.Controls.Add(this.CenterPanel1);
            this.Controls.Add(this.MenuPanel1);
            this.Controls.Add(this.TopPanel);
            this.CloseAnimation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.OpenAnimation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitmonlandia";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreButton)).EndInit();
            this.MenuPanel1.ResumeLayout(false);
            this.MenuPanel2.ResumeLayout(false);
            this.CenterPanel1.ResumeLayout(false);
            this.CenterPanel2.ResumeLayout(false);
            this.CenterPanel2.PerformLayout();
            this.InfoMonthPanel.ResumeLayout(false);
            this.InfoMonthPanel.PerformLayout();
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
        private System.Windows.Forms.Panel CenterPanel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel MenuLabel;
        private Bunifu.Framework.UI.BunifuGradientPanel MenuPanel2;
        private Bunifu.Framework.UI.BunifuFlatButton MapButton;
        private Bunifu.Framework.UI.BunifuFlatButton RestartButton;
        private Bunifu.Framework.UI.BunifuFlatButton SaveButton;
        private Bunifu.Framework.UI.BunifuFlatButton ResultadosButton;
        private Bunifu.Framework.UI.BunifuFlatButton BitmonsMapButton;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuElipse ElipseForm1;
        private Bunifu.Framework.UI.BunifuElipse ElipseMenu2;
        private BunifuAnimatorNS.BunifuTransition OpenAnimation;
        private BunifuAnimatorNS.BunifuTransition CloseAnimation;
        private System.Windows.Forms.Panel InfoMonthPanel;
        private Bunifu.Framework.UI.BunifuElipse ElipseInfoMonth;
        private Bunifu.Framework.UI.BunifuTileButton Map3Button;
        private Bunifu.Framework.UI.BunifuTileButton Map2Button;
        private Bunifu.Framework.UI.BunifuTileButton Map1Button;
        private System.Windows.Forms.Label InfoMonthLabel;
        private Bunifu.Framework.UI.BunifuElipse ElipseMap1;
        private Bunifu.Framework.UI.BunifuElipse ElipseMap2;
        private Bunifu.Framework.UI.BunifuElipse ElipseMap3;
        private System.Windows.Forms.Label MapSizeLabel;
        private System.Windows.Forms.TableLayoutPanel MapPanel;
        private System.Windows.Forms.Panel CenterPanel2;
        private Bunifu.Framework.UI.BunifuElipse ElipseCenterPanel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MonthNumberBox;
        private Bunifu.Framework.UI.BunifuFlatButton NextMonthButton;
        private System.Windows.Forms.Label MonthNumberLabel;
        private Bunifu.Framework.UI.BunifuElipse ElipseNextMonth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label BitmonsMapLabel;
        private System.Windows.Forms.Label ResultadosLabel;
        private System.Windows.Forms.Label TitleMonthInfoLabel;
    }
}

