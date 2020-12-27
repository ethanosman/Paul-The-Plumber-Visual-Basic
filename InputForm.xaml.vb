Public Class InputForm
    Private Sub btnCalculate_Click(sender As Object, e As RoutedEventArgs) Handles btnCalculate.Click

        Dim labourCosts, travelCosts, plasticPipeCosts, totalCosts As Double

        labourCosts = Double.Parse(txtLabourHours.Text) * 35.0
        travelCosts = Double.Parse(txtTravelLength.Text) * 2.0
        plasticPipeCosts = Double.Parse(txtPlasticPipeLength.Text) * 3.0

        totalCosts = labourCosts + travelCosts + plasticPipeCosts

        lblLabourCosts.Content = "Labour Costs: £" + labourCosts.ToString("#.##")
        lblTravelCosts.Content = "Travel Costs: £" + travelCosts.ToString("#,##")
        lblPlasticPipeCosts.Content = "Plastic Pipe Costs: £" + plasticPipeCosts.ToString("#,##")

        lblTotalCosts.Content = "Total Costs: £" + totalCosts.ToString("#,##")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As RoutedEventArgs) Handles btnClear.Click

        txtLabourHours.Text = "0"
        txtTravelLength.Text = "0"
        txtPlasticPipeLength.Text = "0"

        lblLabourCosts.Content = "Labour Costs: £0"
        lblTravelCosts.Content = "Travel Costs: £0"
        lblPlasticPipeCosts.Content = "Plastic Pipe Costs: £0"

        lblTotalCosts.Content = "Total Costs: £0"

    End Sub

    Private Sub btnExit_Click(sender As Object, e As RoutedEventArgs) Handles btnExit.Click

        Close()

    End Sub

End Class
