﻿using Xamarin.Forms;
using Xappy.Content.Blog;
using Xappy.Content.Scenarios.Conversation;
using Xappy.Content.Scenarios.Login;
using Xappy.Content.Scenarios.PhotoGallery;
using Xappy.Content.Scenarios.ProductDetails;
using Xappy.Content.Scenarios.ToDo;
using Xappy.Content.Settings;
using Xappy.ControlGallery;
using Xappy.Scenarios;

namespace Xappy
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("control", typeof(ControlPage));
            Routing.RegisterRoute("map", typeof(MapPage));
            Routing.RegisterRoute("login", typeof(LoginPage));
            Routing.RegisterRoute("otherlogin", typeof(Content.Scenarios.OtherLogin.LoginPage));
            Routing.RegisterRoute("todo", typeof(ItemsPage));
            Routing.RegisterRoute("conversation", typeof(ConversationPage));
            Routing.RegisterRoute("productdetails", typeof(ProductDetailsPage));
            Routing.RegisterRoute("blog", typeof(Content.Blog.IndexPage));
            Routing.RegisterRoute("blogDetail", typeof(BlogDetailPage));
            Routing.RegisterRoute("settings", typeof(SettingsPage));

            // ToDo
            Routing.RegisterRoute("add", typeof(NewItemPage));

            Routing.RegisterRoute("photo", typeof(PhotoDetailsPage));

            Routing.RegisterRoute("onboarding", typeof(Content.Scenarios.Onboarding.IndexPage));
            Routing.RegisterRoute("photogallery", typeof(Content.Scenarios.PhotoGallery.IndexPage));
        }
    }
}
