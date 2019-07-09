﻿using System;
using MediatR;

namespace PingDong.Newmoon.Places.Core
{
    public class PlaceTemporaryClosedDomainEvent : INotification
    {
        public Guid PlaceId { get; }
        public string PlaceName { get; }

        public PlaceTemporaryClosedDomainEvent(Guid placeId, string placeName)
        {
            PlaceId = placeId;
            PlaceName = placeName;
        }
    }
}
