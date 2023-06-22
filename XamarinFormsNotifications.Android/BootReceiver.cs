using Android.App;
using Android.Content;

namespace XamarinFormsNotifications.Droid
{
    [BroadcastReceiver(Enabled = true, Label = "Reboot complete receiver")]
    [IntentFilter(new[] { Intent.ActionBootCompleted })]
    public class BootReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            if (intent.Action == "android.intent.action.BOOT_COMPLETED")
            {
                // Recreate alarms
            }
        }
    }
}