﻿using System;

namespace Delegates_and_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();

            videoEncoder.Encode(video);
        }
    }
}
