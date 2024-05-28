Public Class R6SiegeDataCenterSelector
    Private dataCenterCodes As Dictionary(Of String, String)
    Dim ini As New IniFile(".\GameSettings.ini")

    Private Sub R6SiegeDataCenterSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataCenter As String

        dataCenterCodes = New Dictionary(Of String, String)
        dataCenterCodes.Add("Ping Based", "default")
        dataCenterCodes.Add("East US", "eastus")
        dataCenterCodes.Add("Central US", "centralus")
        dataCenterCodes.Add("South Central US", "southcentralus")
        dataCenterCodes.Add("West US", "westus")
        dataCenterCodes.Add("Brazil South", "brazilsouth")
        dataCenterCodes.Add("North Europe", "northeurope")
        dataCenterCodes.Add("West Europe", "westeurope")
        dataCenterCodes.Add("South Africa North", "southafricanorth")
        dataCenterCodes.Add("East Asia", "Eastasia")
        dataCenterCodes.Add("South East Asia", "southeastasia")
        dataCenterCodes.Add("Australia East", "australiaeast")
        dataCenterCodes.Add("Australia South East", "australiasoutheast")
        dataCenterCodes.Add("Japan west", "japanwest")

        dataCenter = ini.ReadValue("ONLINE", "DataCenterHint")
        For Each center As String In dataCenterCodes.Keys
            If dataCenter = dataCenterCodes.Item(center) Then
                Me.CurrentDataCenterLabel.Text = "Current Data Center: " + center
            End If
        Next

        For Each center As String In dataCenterCodes.Keys
            Me.DataCenterComboBox.Items.Add(center)
        Next
        Me.DataCenterComboBox.SelectedIndex = 0
    End Sub

    Private Sub ChangeDataCenter_Click(sender As Object, e As EventArgs) Handles ChangeDataCenterButton.Click
        Me.CurrentDataCenterLabel.Text = "Current Data Center: " + Me.DataCenterComboBox.SelectedItem.ToString
        ini.WriteValue("ONLINE", "DataCenterHint", dataCenterCodes.Item(Me.DataCenterComboBox.SelectedItem.ToString))
    End Sub

    Private Sub DataCenterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DataCenterComboBox.SelectedIndexChanged

    End Sub
End Class
