﻿using System;

namespace Octopus.Client.Model
{
    public  class FeedResource : Resource, INamedResource
    {
        [Obsolete("The FeedResource type has been depricated on Octopus Deploy 3.5 servers. Use NuGetFeedResource instead")]
        public FeedResource()
        {
            Password = new SensitiveValue();
        }

        [Writeable]
        public string Name { get; set; }

        [Writeable]
        public string FeedUri { get; set; }

        [Writeable]
        public string Username { get; set; }

        [Writeable]
        public SensitiveValue Password { get; set; }

        [WriteableOnCreate]
        public virtual FeedType FeedType { get; }
    }
}