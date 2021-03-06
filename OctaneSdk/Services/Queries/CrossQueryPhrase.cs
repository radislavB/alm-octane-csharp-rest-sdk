﻿/*!
* (c) 2016-2018 EntIT Software LLC, a Micro Focus company
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/


using System;
using System.Collections.Generic;

namespace MicroFocus.Adm.Octane.Api.Core.Services.Query

{
	/// <summary>
	/// Used to execute filter by cross entities, for example : get defects by "owner" name
	/// </summary>
	public class CrossQueryPhrase : QueryPhrase
    {
        public string FieldName { get; set; }

        public IList<QueryPhrase> QueryPhrases { get; set; }

        public CrossQueryPhrase(string fieldName, QueryPhrase queryPhrase)
        {
            this.FieldName = fieldName;
            this.QueryPhrases = new List<QueryPhrase>() { queryPhrase  };
        }

        public CrossQueryPhrase(string fieldName, IList<QueryPhrase> queryPhrases)
        {
            this.FieldName = fieldName;
            this.QueryPhrases = queryPhrases;
        }
    }
}
