﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Newtonsoft.Json;

namespace Microsoft.DotNet.VersionTools.Automation.GitHubApi
{
    /// <summary>
    /// The interesting parts of a GitHub pull request, as returned by the pull request api.
    /// </summary>
    public class GitHubPullRequest
    {
        public int Number { get; set; }
        public string Title { get; set; }
        public GitHubHead Head { get; set; }
        public GitHubUser User { get; set; }
    }

    public class GitHubHead
    {
        public string Label { get; set; }
        public string Ref { get; set; }
        public string Sha { get; set; }
        public GitHubUser User { get; set; }
    }

    public class GitHubUser
    {
        public string Login { get; set; }
    }

    public class GitHubIssueQueryResponse
    {
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
        public GitHubIssue[] Items { get; set; }
    }

    public class GitHubIssue
    {
        public int Id { get; set; }
        public int Number { get; set; }
    }

    public class GitCommit
    {
        public string Sha { get; set; }
        public GitCommitUser Author { get; set; }
        public GitCommitUser Committer { get; set; }
    }

    public class GitCommitUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
