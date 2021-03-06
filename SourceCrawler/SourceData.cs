/*
 * Copyright (c) 2020, salesforce.com, inc.
 * All rights reserved.
 * SPDX-License-Identifier: BSD-3-Clause
 * For full license text, see the LICENSE file in the repo root or https://opensource.org/licenses/BSD-3-Clause
 */

using System.IO;

namespace SourceCrawler
{
    public class SourceData
    {
        public string PathToSolution { get; set; }
        public string SolutionFileName { get; set; }
        public string FullSourceText { get; set; }
        public string PathToSource { get; set; }
        public string SourceFileName { get; set; }
        public string PathToProject { get; set; }
        public string ProjectFileName { get; set; }

        public string SolutionPathAndFileName
        {
            get
            {
                return Path.Combine(PathToSolution, SolutionFileName);
            }
        }

        public string SourcePathAndFileName
        {
            get
            {
                return Path.Combine(PathToSource, SourceFileName);
            }
        }

        public string ProjectPathAndFileName
        {
            get { return Path.Combine(PathToProject, ProjectFileName); }
        }
    }
}
