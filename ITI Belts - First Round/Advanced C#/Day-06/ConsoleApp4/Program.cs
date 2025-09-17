namespace ConsoleApp4
{
    internal class Program
    {
        static void ShowDoorStatus(object sender, DoorEventArgs e)
        {
            Console.WriteLine(e.IsLocked ? "Door is locked!" : "Door is unlocked!");
        }
        static void PlayLockSound(object sender, DoorEventArgs e)
        {
            Console.WriteLine("Lock sound played!");
        }
        static void Main(string[] args)
        {
            DoorLock lockObj = new DoorLock();
            lockObj.DoorStateChanged += ShowDoorStatus;
            lockObj.DoorStateChanged += PlayLockSound;

            lockObj.LockDoor(true);
            lockObj.LockDoor(false);
        }
    }
}
