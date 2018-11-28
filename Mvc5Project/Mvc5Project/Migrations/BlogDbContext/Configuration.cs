namespace Mvc5Project.Migrations.BlogDbContext
{
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Mvc5Project.Models.BlogDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\BlogDbContext";
        }

        protected override void Seed(Mvc5Project.Models.BlogDbContext context)
        {
            context.Categories.AddOrUpdate(new Models.Category { Id = "cat1", Name = "Lorem", UrlSeo = "Lorem", Description = "Lorem Category" });
            context.Categories.AddOrUpdate(new Models.Category { Id = "cat2", Name = "Duis", UrlSeo = "Duis", Description = "Duis Category" });
            context.Categories.AddOrUpdate(new Models.Category { Id = "cat3", Name = "Nulla", UrlSeo = "Nulla", Description = "Nulla Category" });
            context.Categories.AddOrUpdate(new Models.Category { Id = "cat4", Name = "Ipsum", UrlSeo = "Ipsum", Description = "Ipsum Category" });

            context.Posts.AddOrUpdate(new Models.Post
            {
                Id = "1",
                Title = "Lorem",
                Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Vivamus morbi at risus eget tortor pharetra cursus eu at ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk" +
                " djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus morbi at risus eget" +
                " tortor pharetra cursus eu at ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if" +
                " dfdjfd fd.dsfds fdk. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus morbi at risus eget tortor pharetra cursus eu at " +
                "ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk. Lorem ipsum" +
                " dolor sit amet, consectetur adipiscing elit. Vivamus morbi at risus eget tortor pharetra cursus eu at ligula. mausis ei commod nisl,, ac " +
                "loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk. Lorem ipsum dolor sit amet, consectetur adipiscing " +
                "elit. Vivamus morbi at risus eget tortor pharetra cursus eu at ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk " +
                "djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus morbi at risus eget tortor" +
                " pharetra cursus eu at ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if dfdjfd fd." +
                "dsfds fdk.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus morbi at risus eget tortor pharetra cursus eu at ligula. mausis ei" +
                " commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk.Lorem ipsum dolor sit amet, " +
                "consectetur adipiscing elit. Vivamus morbi at risus eget tortor pharetra cursus eu at ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut" +
                " rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus morbi " +
                "at risus eget tortor pharetra cursus eu at ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd" +
                " if dfdjfd fd.dsfds fdk.",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus morbi at risus eget tortor pharetra cursus eu at ligula. mausis" +
                " ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk.",
                PostedOn = DateTime.Now,
                Meta = "Lorem",
                UrlSeo = "Lorem",
                Published = true
            });

            context.Posts.AddOrUpdate(new Models.Post
            {
                Id = "2",
                Title = "Duis",
                Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Vivamus morbi at risus eget tortor pharetra cursus eu at ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk" +
                " djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus morbi at risus eget" +
                " tortor pharetra cursus eu at ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if" +
                " dfdjfd fd.dsfds fdk. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus morbi at risus eget tortor pharetra cursus eu at " +
                "ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk. Lorem ipsum" +
                " dolor sit amet, consectetur adipiscing elit. Vivamus morbi at risus eget tortor pharetra cursus eu at ligula. mausis ei commod nisl,, ac " +
                "loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk. Lorem ipsum dolor sit amet, consectetur adipiscing " +
                "elit. Vivamus morbi at risus eget tortor pharetra cursus eu at ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk " +
                "djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus morbi at risus eget tortor" +
                " pharetra cursus eu at ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if dfdjfd fd." +
                "dsfds fdk.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus morbi at risus eget tortor pharetra cursus eu at ligula. mausis ei" +
                " commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk.Lorem ipsum dolor sit amet, " +
                "consectetur adipiscing elit. Vivamus morbi at risus eget tortor pharetra cursus eu at ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut" +
                " rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus morbi " +
                "at risus eget tortor pharetra cursus eu at ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd" +
                " if dfdjfd fd.dsfds fdk.",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus morbi at risus eget tortor pharetra cursus eu at ligula. mausis" +
                " ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk.",
                PostedOn = DateTime.Now,
                Meta = "Duis",
                UrlSeo = "Duis",
                Published = true
            });

            context.Posts.AddOrUpdate(new Models.Post
            {
                Id = "3",
                Title = "Nulla",
                Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Vivamus morbi at risus eget tortor pharetra cursus eu at ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk" +
                " djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus morbi at risus eget" +
                " tortor pharetra cursus eu at ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if" +
                " dfdjfd fd.dsfds fdk. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus morbi at risus eget tortor pharetra cursus eu at " +
                "ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk. Lorem ipsum" +
                " dolor sit amet, consectetur adipiscing elit. Vivamus morbi at risus eget tortor pharetra cursus eu at ligula. mausis ei commod nisl,, ac " +
                "loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk. Lorem ipsum dolor sit amet, consectetur adipiscing " +
                "elit. Vivamus morbi at risus eget tortor pharetra cursus eu at ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk " +
                "djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus morbi at risus eget tortor" +
                " pharetra cursus eu at ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if dfdjfd fd." +
                "dsfds fdk.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus morbi at risus eget tortor pharetra cursus eu at ligula. mausis ei" +
                " commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk.Lorem ipsum dolor sit amet, " +
                "consectetur adipiscing elit. Vivamus morbi at risus eget tortor pharetra cursus eu at ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut" +
                " rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus morbi " +
                "at risus eget tortor pharetra cursus eu at ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd" +
                " if dfdjfd fd.dsfds fdk.",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus morbi at risus eget tortor pharetra cursus eu at ligula. mausis" +
                " ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk.",
                PostedOn = DateTime.Now,
                Meta = "Nulla",
                UrlSeo = "Nulla",
                Published = true
            });

            context.Posts.AddOrUpdate(new Models.Post
            {
                Id = "4",
                Title = "Ipsum",
                Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Vivamus morbi at risus eget tortor pharetra cursus eu at ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk" +
                " djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus morbi at risus eget" +
                " tortor pharetra cursus eu at ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if" +
                " dfdjfd fd.dsfds fdk. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus morbi at risus eget tortor pharetra cursus eu at " +
                "ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk. Lorem ipsum" +
                " dolor sit amet, consectetur adipiscing elit. Vivamus morbi at risus eget tortor pharetra cursus eu at ligula. mausis ei commod nisl,, ac " +
                "loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk. Lorem ipsum dolor sit amet, consectetur adipiscing " +
                "elit. Vivamus morbi at risus eget tortor pharetra cursus eu at ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk " +
                "djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus morbi at risus eget tortor" +
                " pharetra cursus eu at ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if dfdjfd fd." +
                "dsfds fdk.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus morbi at risus eget tortor pharetra cursus eu at ligula. mausis ei" +
                " commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk.Lorem ipsum dolor sit amet, " +
                "consectetur adipiscing elit. Vivamus morbi at risus eget tortor pharetra cursus eu at ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut" +
                " rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus morbi " +
                "at risus eget tortor pharetra cursus eu at ligula. mausis ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd" +
                " if dfdjfd fd.dsfds fdk.",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus morbi at risus eget tortor pharetra cursus eu at ligula. mausis" +
                " ei commod nisl,, ac loboaier lenckjdf, ut rhod kdjfd oewi djfdk djdkf . ksdjfdk. dkjdjfd if dfdjfd fd.dsfds fdk.",
                PostedOn = DateTime.Now,
                Meta = "Ipsum",
                UrlSeo = "Upsum",
                Published = true
            });

            context.PostCategories.AddOrUpdate(new Models.PostCategory { PostId = "1", CategoryId = "cat1" });
            context.PostCategories.AddOrUpdate(new Models.PostCategory { PostId = "1", CategoryId = "cat4" });
            context.PostCategories.AddOrUpdate(new Models.PostCategory { PostId = "2", CategoryId = "cat2" });
            context.PostCategories.AddOrUpdate(new Models.PostCategory { PostId = "3", CategoryId = "cat3" });

            context.PostVideos.AddOrUpdate(new Models.PostVideo { Id = 1, PostId = "1", VideoSiteName = "Youtube", VideoUrl = "https://www.youtube.com/embed/Pnhxz0learg", VideoThumbnail = "http://i.ytimg.com/vi/Pnhxz0learg/maxresdefault.jpg" });
            context.PostVideos.AddOrUpdate(new Models.PostVideo { Id = 1, PostId = "2", VideoSiteName = "Youtube", VideoUrl = "https://www.youtube.com/embed/L6-hCpnFjLg", VideoThumbnail = "http://i.ytimg.com/vi/L6-hCpnFjLg/maxresdefault.jpg" });
            context.PostVideos.AddOrUpdate(new Models.PostVideo { Id = 1, PostId = "3", VideoSiteName = "Youtube", VideoUrl = "https://www.youtube.com/embed/bBrUrgNf5y8", VideoThumbnail = "http://i.ytimg.com/vi/bBrUrgNf5y8/maxresdefault.jpg" });
            context.PostVideos.AddOrUpdate(new Models.PostVideo { Id = 1, PostId = "1", VideoSiteName = "Youtube", VideoUrl = "https://www.youtube.com/embed/JAzZ0R7eo_s", VideoThumbnail = "http://i.ytimg.com/vi/JAzZ0R7eo_s/maxresdefault.jpg" });


        }
    }
}