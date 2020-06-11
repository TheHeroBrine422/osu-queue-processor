// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Diagnostics.CodeAnalysis;
using osu.Server.QueueProcessor;

namespace osu.Server.Queues.ManiaKeyRankingProcessor
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class ScoreItem : QueueItem
    {
        public int score_id { get; set; }

        public bool high { get; set; }

        public override string ToString() => $"score_id: {score_id} high: {high}";
    }
}
