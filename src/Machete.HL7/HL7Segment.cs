﻿namespace Machete.HL7
{
    public interface HL7Segment :
        HL7Entity
    {
        Value<string> SegmentId { get; }
        Value<bool> IsEmpty { get; }
        ValueList<string> Fields { get; }
    }
}