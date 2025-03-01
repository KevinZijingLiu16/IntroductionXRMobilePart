using UnityEngine.Android;
using Unity.Notifications.Android;
using UnityEngine;

public class Notification : MonoBehaviour
{
    void Start()
    {   // initialize/register the notification channel
        var channel = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Default Channel",
            Importance = Importance.Default,
            Description = "Generic notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel);


        //make sure the App has the permission to send notifications to user

        if(!Permission.HasUserAuthorizedPermission("android.permission.POST_NOTIFICATIONS"))
        {
            Permission.RequestUserPermission("android.permission.POST_NOTIFICATIONS");
        }

        // create and send the notification

        var notification = new AndroidNotification();
        notification.Title = "This is Notification Title";
        notification.Text = "HI, this is the nutification text";
        notification.FireTime = System.DateTime.Now.AddMinutes(1);

        AndroidNotificationCenter.SendNotification(notification, "channel_id");

        notification.LargeIcon = "my_custom_large_icon_id";

    }
}
