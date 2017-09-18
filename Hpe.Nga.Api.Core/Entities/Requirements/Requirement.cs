﻿// (c) Copyright 2016 Hewlett Packard Enterprise Development LP

// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License.

// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS,

// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.

// See the License for the specific language governing permissions and limitations under the License.

namespace Hpe.Nga.Api.Core.Entities
{
    /// <summary>
    /// Wrapper for Run entity
    /// More fields might be supported by entity that still are not exposed in the class
    /// </summary>
    public class Requirement : BaseEntity
    {
        public static string SUBTYPE_FIELD = "subtype";
        public static string SUBTYPE_DOCUMENT = "requirement_document";

        public Requirement()
        {
        }

        public Requirement(long id)
            : base(id)
        {
        }

        public string SubType
        {
            get
            {
                return GetStringValue(SUBTYPE_FIELD);
            }
            set
            {
                SetValue(SUBTYPE_FIELD, value);
            }

        }

    }
}
