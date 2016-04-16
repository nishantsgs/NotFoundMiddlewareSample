﻿namespace NotFoundMiddlewareSample.Middleware
{
    public class NotFoundRequest
    {
        public NotFoundRequest(string path)
        {
            Path = path;
        }

        public string Path { get; }
        public int Count { get; private set; }

        public void IncrementCount()
        {
            Count++;
        }
    }
}