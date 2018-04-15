﻿using Microsoft.EntityFrameworkCore.Query;

namespace Impatient.EFCore.Tests
{
    public class IncludeAsyncImpatientTest : IncludeAsyncTestBase<NorthwindQueryImpatientFixture>
    {
        public IncludeAsyncImpatientTest(NorthwindQueryImpatientFixture fixture) : base(fixture)
        {
        }
    }
}
