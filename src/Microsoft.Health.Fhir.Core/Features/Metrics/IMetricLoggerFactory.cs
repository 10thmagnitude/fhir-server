﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace Microsoft.Health.Fhir.Core.Features.Metrics
{
    public interface IMetricLoggerFactory
    {
        IMetricLogger CreateMetricLogger(string metricName, params string[] dimensions);
    }
}
