using EJE.HELPER.IP;
/*
private void btnGetIP_Click(object sender, EventArgs e)
{
    string ipLocal = IpHelper.GetLocalIPAddress();
    MessageBox.Show("La IP local es: " + ipLocal);
}
*/


string ipLocal = IPHelper.GetLocalIPAddress();
Console.WriteLine("La IP local es: " + ipLocal);