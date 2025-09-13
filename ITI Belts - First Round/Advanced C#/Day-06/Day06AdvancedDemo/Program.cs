namespace Day06AdvancedDemo
{
    delegate void AlaramHandler();

    delegate void EmergencyHandler(string level);

    internal class Program
    {
        static void OnAlarmRang()
        {
            Console.WriteLine("Wake up! Alarm is ringing");
        }

        static void SendNotification()
        {
            Console.WriteLine("Sending notification: Alarm is ringing");
        }

        static void ShowPopup()
        {
            Console.WriteLine("Showing popup: Alarm is ringing");
        }

        static void PlaySound()
        {
            Console.WriteLine("Playing sound: Alarm is ringing");
        }

        //------------------------------------------------------------

        static void CallPolice(string level)
        {
            Console.WriteLine("Calling police for level: " + level);
        }

        static void AlertSecurity(string level)
        {
            Console.WriteLine("Alerting security for level: " + level);
        }

        //-------------------------------------------------------------

        static void OnButtonClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Button click event handlled");
        }

        //-------------------------------------------------------------

        static void LightOn(object sender, SwitchEventArgs e)
        {
            Console.WriteLine("Light is on");
        }

        static void PlayBeepSound(object sender, SwitchEventArgs e)
        {
            Console.WriteLine("Beep Beep sound!");
        }
        //-------------------------------------------------------------


        static void ShowMessage()
        {
            Console.WriteLine("Timer tick recieved");
        }
        static void Main(string[] args)
        {
            //Alarm alarm = new Alarm();

            //alarm.AlarmRang += OnAlarmRang;
            //alarm.AlarmRang += SendNotification;
            //alarm.AlarmRang += ShowPopup;
            //alarm.AlarmRang += PlaySound;

            //alarm.Ring();


            //EmergencyButton button = new EmergencyButton();


            //button.ButtonPressed += CallPolice;
            //button.ButtonPressed += AlertSecurity;
            //button.Press("High");


            //Button btn = new Button();

            //btn.Clicked += OnButtonClicked;

            //btn.Click();


            //Switch sw = new Switch();

            //sw.TurnedOn += LightOn;
            //sw.TurnedOn += PlayBeepSound;


            //sw.TurnOn();


            //Timer t = new Timer();

            //t.Tick += ShowMessage;

            //t.Tick += () => Console.WriteLine("another subscriper event recieved");

            //t.Start();



            //Exam exam = new Exam();

            //exam.CalculateAverage += (m, s, e) => (m + s + e) / 3.0;

            //exam.ShowAverage(91, 83, 76);



            //NumberFilter filter = new NumberFilter();

            //filter.CheckNumber += n => n % 2 == 0;

            //filter.ShowNumbers(new int[] { 1, 2, 3, 4, 5, 6 });
               
        }
    }
}
