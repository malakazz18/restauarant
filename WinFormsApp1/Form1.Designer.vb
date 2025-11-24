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
        rdpizza = New RadioButton()
        rdburger = New RadioButton()
        rdpates = New RadioButton()
        Label1 = New Label()
        Label2 = New Label()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        Label3 = New Label()
        ListBox1 = New ListBox()
        Button1 = New Button()
        Button2 = New Button()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' rdpizza
        ' 
        rdpizza.AutoSize = True
        rdpizza.Location = New Point(90, 104)
        rdpizza.Name = "rdpizza"
        rdpizza.Size = New Size(65, 24)
        rdpizza.TabIndex = 1
        rdpizza.TabStop = True
        rdpizza.Text = "pizza"
        rdpizza.UseVisualStyleBackColor = True
        ' 
        ' rdburger
        ' 
        rdburger.AutoSize = True
        rdburger.Location = New Point(90, 166)
        rdburger.Name = "rdburger"
        rdburger.Size = New Size(74, 24)
        rdburger.TabIndex = 2
        rdburger.TabStop = True
        rdburger.Text = "Burger"
        rdburger.UseVisualStyleBackColor = True
        ' 
        ' rdpates
        ' 
        rdpates.AutoSize = True
        rdpates.Location = New Point(90, 229)
        rdpates.Name = "rdpates"
        rdpates.Size = New Size(64, 24)
        rdpates.TabIndex = 3
        rdpates.TabStop = True
        rdpates.Text = "Pates"
        rdpates.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(90, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 20)
        Label1.TabIndex = 4
        Label1.Text = "Choix du plat"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(393, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 5
        Label2.Text = "Supplement"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(393, 104)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(88, 24)
        CheckBox1.TabIndex = 6
        CheckBox1.Text = "fromage"
        CheckBox1.TextAlign = ContentAlignment.MiddleCenter
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(393, 166)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(64, 24)
        CheckBox2.TabIndex = 7
        CheckBox2.Text = "frites"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(393, 230)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(78, 24)
        CheckBox3.TabIndex = 8
        CheckBox3.Text = "dessert"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(66, 308)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 20)
        Label3.TabIndex = 9
        Label3.Text = "Boisson"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(163, 308)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(150, 104)
        ListBox1.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(377, 348)
        Button1.Name = "Button1"
        Button1.Size = New Size(143, 29)
        Button1.TabIndex = 11
        Button1.Text = "commander"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(587, 348)
        Button2.Name = "Button2"
        Button2.Size = New Size(143, 29)
        Button2.TabIndex = 12
        Button2.Text = "Annuler"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(613, 85)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 20)
        Label4.TabIndex = 13
        Label4.Text = "Facture:"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(710, 85)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 20)
        Label5.TabIndex = 14
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ListBox1)
        Controls.Add(Label3)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(rdpates)
        Controls.Add(rdburger)
        Controls.Add(rdpizza)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents rdpizza As RadioButton
    Friend WithEvents rdburger As RadioButton
    Friend WithEvents rdpates As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
