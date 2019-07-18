﻿using System;
using PingDong.CleanArchitect.Core;

namespace PingDong.Newmoon.Places.Service.IntegrationEvents
{
    public class PlaceOccupiedIntegrationEvent : IntegrationEvent
    {
        public PlaceOccupiedIntegrationEvent(Guid placeId, string placeName)
        {
            PlaceId = placeId;
            PlaceName = placeName;
        }

        public Guid PlaceId { get; }
        public string PlaceName { get; }
    }
}
