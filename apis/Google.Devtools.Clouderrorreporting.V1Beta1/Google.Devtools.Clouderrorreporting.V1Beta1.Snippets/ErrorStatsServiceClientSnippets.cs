﻿// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static Google.Devtools.Clouderrorreporting.V1Beta1.QueryTimeRange.Types;

namespace Google.Devtools.Clouderrorreporting.V1Beta1.Snippets
{
    [Collection(nameof(ErrorReportingFixture))]
    public class ErrorStatsServiceClientSnippets
    {
        private readonly ErrorReportingFixture _fixture;

        public ErrorStatsServiceClientSnippets(ErrorReportingFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void ListGroupStats()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: ListGroupStats
            ErrorStatsServiceClient client = ErrorStatsServiceClient.Create();
            string projectName = ErrorStatsServiceClient.FormatProjectName(projectId);
            IPagedEnumerable<ListGroupStatsResponse, ErrorGroupStats> groupStats = client.ListGroupStats(
                projectName,
                new QueryTimeRange { Period = Period._30Days });
            foreach (ErrorGroupStats item in groupStats)
            {
                // Sample output: Group: 8002882452986879952; Count: 6; Services: SampleApp/1.0.0
                IEnumerable<string> services = item.AffectedServices.Select(s => $"{s.Service}/{s.Version}");
                Console.WriteLine($"Group: {item.Group.GroupId}; Count: {item.Count}; Services: {string.Join(", ", services)}");
            }            
            // End snippet
        }
    }
}
