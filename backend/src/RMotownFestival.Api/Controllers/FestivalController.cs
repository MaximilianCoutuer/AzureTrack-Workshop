using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.ApplicationInsights;
using Microsoft.AspNetCore.Mvc;

using RMotownFestival.Api.Data;
using RMotownFestival.Api.Domain;
using RMotownFestival.DAL;

namespace RMotownFestival.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FestivalController : ControllerBase
    {
        private MotownDbContext Context { get; }
        private TelemetryClient TelemetryClient { get; }

        public FestivalController(MotownDbContext context, TelemetryClient telemetryClient)
        {
            Context = context;
            TelemetryClient = telemetryClient;
        }

        [HttpGet("LineUp")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(Schedule))]
        public ActionResult GetLineUp()
        {
            throw new ApplicationException("My microsoft is crash");
            return Ok(FestivalDataSource.Current.LineUp);
        }

        [HttpGet("Artists")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<Artist>))]
        public ActionResult GetArtists(bool? withRatings)
        {
            if (withRatings.HasValue && withRatings.Value) TelemetryClient.TrackEvent($"List of artists with rating"); else TelemetryClient.TrackEvent($"List of artists without rating");
            return Ok(Context.Artists);
        }

        [HttpGet("Stages")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<Stage>))]
        public ActionResult GetStages()
        {
            return Ok(Context.Stages);
        }

        [HttpPost("Favorite")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ScheduleItem))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public ActionResult SetAsFavorite(int id)
        {
            var schedule = FestivalDataSource.Current.LineUp.Items
                .FirstOrDefault(si => si.Id == id);
            if (schedule != null)
            {
                schedule.IsFavorite = !schedule.IsFavorite;
                return Ok(schedule);
            }
            return NotFound();
        }

    }
}