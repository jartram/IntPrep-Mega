/*
 =======================================================================================
 CHALLENGE: WebCrawler
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the WebCrawler problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.WebCrawlerTests
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class WebCrawler
    {
        public IList<string> Crawl(string startUrl, HtmlParser htmlParser)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private string GetHostName(string url)
        {
            var i = 0;
            var sb = new StringBuilder();

            if (url[0] == 'h')
            {
                while (url[i] != '/')
                {
                    i++;
                }

                while (url[i] == '/')
                {
                    i++;
                }
            }

            for (int index = i; i < url.Length && url[i] != '/'; i++)
            {
                sb.Append(url[i]);
            }

            return sb.ToString();
        }
    }
}
