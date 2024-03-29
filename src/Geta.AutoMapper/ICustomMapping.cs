﻿// Copyright (c) Geta Digital. All rights reserved.
// Licensed under Apache-2.0. See the LICENSE file in the project root for more information

using AutoMapper;

namespace Geta.AutoMapper
{
    public interface ICustomMapping
    {
        void CreateMapping(IMapperConfigurationExpression configuration);
    }
}