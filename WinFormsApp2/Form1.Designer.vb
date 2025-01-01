<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblnominal = New Label()
        lblbunga = New Label()
        lbljangkawaktu = New Label()
        lblhasil = New Label()
        txttabungan = New TextBox()
        nmcbunga = New NumericUpDown()
        nmcjangkawaktu = New NumericUpDown()
        btnhitung = New Button()
        btnexit = New Button()
        CType(nmcbunga, ComponentModel.ISupportInitialize).BeginInit()
        CType(nmcjangkawaktu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblnominal
        ' 
        lblnominal.AutoSize = True
        lblnominal.Location = New Point(60, 40)
        lblnominal.Name = "lblnominal"
        lblnominal.Size = New Size(161, 15)
        lblnominal.TabIndex = 0
        lblnominal.Text = "Nominal Yang Akan Dihitung"
        ' 
        ' lblbunga
        ' 
        lblbunga.AutoSize = True
        lblbunga.Location = New Point(60, 79)
        lblbunga.Name = "lblbunga"
        lblbunga.Size = New Size(117, 15)
        lblbunga.TabIndex = 1
        lblbunga.Text = "Bunga Per Tahun (%)"
        ' 
        ' lbljangkawaktu
        ' 
        lbljangkawaktu.AutoSize = True
        lbljangkawaktu.Location = New Point(60, 119)
        lbljangkawaktu.Name = "lbljangkawaktu"
        lbljangkawaktu.Size = New Size(121, 15)
        lbljangkawaktu.TabIndex = 2
        lbljangkawaktu.Text = "Jangka Waktu (Bulan)"
        ' 
        ' lblhasil
        ' 
        lblhasil.AutoSize = True
        lblhasil.Location = New Point(60, 162)
        lblhasil.Name = "lblhasil"
        lblhasil.Size = New Size(33, 15)
        lblhasil.TabIndex = 3
        lblhasil.Text = "Hasil"
        ' 
        ' txttabungan
        ' 
        txttabungan.Location = New Point(268, 37)
        txttabungan.Name = "txttabungan"
        txttabungan.Size = New Size(142, 23)
        txttabungan.TabIndex = 4
        ' 
        ' nmcbunga
        ' 
        nmcbunga.Location = New Point(268, 77)
        nmcbunga.Name = "nmcbunga"
        nmcbunga.Size = New Size(142, 23)
        nmcbunga.TabIndex = 5
        ' 
        ' nmcjangkawaktu
        ' 
        nmcjangkawaktu.Location = New Point(268, 111)
        nmcjangkawaktu.Name = "nmcjangkawaktu"
        nmcjangkawaktu.Size = New Size(142, 23)
        nmcjangkawaktu.TabIndex = 6
        ' 
        ' btnhitung
        ' 
        btnhitung.Location = New Point(452, 37)
        btnhitung.Name = "btnhitung"
        btnhitung.Size = New Size(104, 97)
        btnhitung.TabIndex = 7
        btnhitung.Text = "Hitung"
        btnhitung.UseVisualStyleBackColor = True
        ' 
        ' btnexit
        ' 
        btnexit.Location = New Point(210, 234)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(261, 41)
        btnexit.TabIndex = 8
        btnexit.Text = "Exit"
        btnexit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnexit)
        Controls.Add(btnhitung)
        Controls.Add(nmcjangkawaktu)
        Controls.Add(nmcbunga)
        Controls.Add(txttabungan)
        Controls.Add(lblhasil)
        Controls.Add(lbljangkawaktu)
        Controls.Add(lblbunga)
        Controls.Add(lblnominal)
        Name = "Form1"
        Text = "Form1"
        CType(nmcbunga, ComponentModel.ISupportInitialize).EndInit()
        CType(nmcjangkawaktu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblnominal As Label
    Friend WithEvents lblbunga As Label
    Friend WithEvents lbljangkawaktu As Label
    Friend WithEvents lblhasil As Label
    Friend WithEvents txttabungan As TextBox
    Friend WithEvents nmcbunga As NumericUpDown
    Friend WithEvents nmcjangkawaktu As NumericUpDown
    Friend WithEvents btnhitung As Button
    Friend WithEvents btnexit As Button

End Class
