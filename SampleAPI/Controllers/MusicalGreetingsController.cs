namespace SampleAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;

    [Route("dj-damyan")]
    public class MusicalGreetingsController : BaseApiController
    {

        [HttpPost("tip")]
        public string TipDjDamyan(decimal bgnAmount, string songName, string content)
            => @$"{bgnAmount switch
            {
                > 0M and < 5M => $"Evalata starshi, ti metna {bgnAmount} leva!",
                >= 5M and < 10M => $"Za golemiq tigyr, koito metna {bgnAmount} leva tazi vecher!",
                >= 10 => $"Igracha tazi vecher metna {bgnAmount} leva!",
                _ => throw new ArgumentException("Insufficient amount.")
            }} Pesen: {songName} | {content}";
    }
}
