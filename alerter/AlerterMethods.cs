namespace alerter
{
    class AlerterMethods
    {
        public int alertFailureCount = 0;
        INetworkAlert networkAlert;

        public AlerterMethods(INetworkAlert networkAlertobj)
        {
            networkAlert = networkAlertobj;
        }
        static float ConvertFarenheitTocelcius(float farenheit)
        {
            return (farenheit - 32) * 5 / 9;
        }
        public void alertInCelcius(float farenheit)
        {
            float celcius = ConvertFarenheitTocelcius(farenheit);
            int returnCode = networkAlert.networkAlert(celcius);
            if (returnCode != 200)
            {
                // non-ok response is not an error! Issues happen in life!
                // let us keep a count of failures to report
                // However, this code doesn't count failures!
                // Add a test below to catch this bug. Alter the stub above, if needed.
                alertFailureCount += 1;
            }
        }
    }
}
