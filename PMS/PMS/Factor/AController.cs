﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Factor
{
    public class AController : Controller , NotificationController
    {
        // Admin Notifications
        void NotificationController.Get_Query()
        {
            var qu = @"SELECT [NotificationId],[Status],[Message],[ExtraColumn] FROM [dbo].[tbl_Notification]";

            String x = Models.NotificaionService.GetNotification(qu);
        }
    }
}