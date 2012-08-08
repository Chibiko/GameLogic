<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HumanControl
    Inherits System.Windows.Forms.UserControl

    'Пользовательский элемент управления (UserControl) переопределяет метод Dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HumanTire = New System.Windows.Forms.ProgressBar()
        Me.HumanName = New System.Windows.Forms.Label()
        Me.HumanHealth = New System.Windows.Forms.ProgressBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.HumanState = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.HumanID = New System.Windows.Forms.NumericUpDown()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.HumanID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.HumanID)
        Me.SplitContainer1.Panel2.Controls.Add(Me.HumanState)
        Me.SplitContainer1.Panel2.Controls.Add(Me.HumanTire)
        Me.SplitContainer1.Panel2.Controls.Add(Me.HumanName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.HumanHealth)
        Me.SplitContainer1.Size = New System.Drawing.Size(331, 212)
        Me.SplitContainer1.SplitterDistance = 110
        Me.SplitContainer1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Усталость"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Имя"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Здоровье"
        '
        'HumanTire
        '
        Me.HumanTire.Location = New System.Drawing.Point(3, 52)
        Me.HumanTire.Name = "HumanTire"
        Me.HumanTire.Size = New System.Drawing.Size(199, 23)
        Me.HumanTire.TabIndex = 2
        '
        'HumanName
        '
        Me.HumanName.AutoSize = True
        Me.HumanName.Location = New System.Drawing.Point(3, 29)
        Me.HumanName.Name = "HumanName"
        Me.HumanName.Size = New System.Drawing.Size(36, 20)
        Me.HumanName.TabIndex = 1
        Me.HumanName.Text = "___"
        '
        'HumanHealth
        '
        Me.HumanHealth.Location = New System.Drawing.Point(3, 3)
        Me.HumanHealth.Name = "HumanHealth"
        Me.HumanHealth.Size = New System.Drawing.Size(199, 23)
        Me.HumanHealth.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Состояние"
        '
        'HumanState
        '
        Me.HumanState.AutoSize = True
        Me.HumanState.Location = New System.Drawing.Point(3, 78)
        Me.HumanState.Name = "HumanState"
        Me.HumanState.Size = New System.Drawing.Size(36, 20)
        Me.HumanState.TabIndex = 3
        Me.HumanState.Text = "___"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "ID"
        '
        'HumanID
        '
        Me.HumanID.Location = New System.Drawing.Point(3, 101)
        Me.HumanID.Name = "HumanID"
        Me.HumanID.ReadOnly = True
        Me.HumanID.Size = New System.Drawing.Size(57, 26)
        Me.HumanID.TabIndex = 4
        '
        'HumanControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "HumanControl"
        Me.Size = New System.Drawing.Size(331, 212)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.HumanID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents HumanName As System.Windows.Forms.Label
    Private WithEvents HumanHealth As System.Windows.Forms.ProgressBar
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents HumanTire As System.Windows.Forms.ProgressBar
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents HumanID As System.Windows.Forms.NumericUpDown
    Private WithEvents HumanState As System.Windows.Forms.Label

End Class
