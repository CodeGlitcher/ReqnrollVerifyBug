using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Reqnroll;

namespace ReqnrollVerifyBug
{
    [Binding]
    internal class When
    {
        private readonly VerifySettings _settings;

        public When(VerifySettings settings)
        {
            _settings = settings;
        }
        [When("Verify is called there should be no exception")]
        public async Task WhenVerifyIsCalledThereShouldBeNoException()
        {
            await Verify(1, _settings);
        }

    }
}
