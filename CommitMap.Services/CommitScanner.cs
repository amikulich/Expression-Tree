﻿namespace CommitMap.Services
{
    public interface ICommitScanner
    {
        string[] GetModifiedDocuments(string commitHash);
    }

    public class CommitScanner : ICommitScanner
    {
        public string[] GetModifiedDocuments(string commitHash)
        {
            return new string[]
            {
                "Service1.cs",
            };
        }
    }
}
