﻿using NUnit.Framework;

namespace Eloqua.Api.Rest.ClientLibrary.Tests.Clients.Assets
{
    [TestFixture]
    public class LandingPageClientTests
    {
        private Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Client("site", "user", "password", Constants.BaseUrl);
        }

        [Test]
        public void SearchLandingPageTest()
        {
            var landingPages = _client.Assets.LandingPage.Get("*", 1, 100);
            Assert.Greater(landingPages.elements.Count, 0);
        }
    }
}
