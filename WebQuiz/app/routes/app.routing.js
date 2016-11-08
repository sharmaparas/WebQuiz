"use strict";
var router_1 = require("@angular/router");
var default_1 = require("../components/default");
var profile_1 = require("../components/profile");
var appRoutes = [
    {
        path: "",
        component: default_1.DefaultComponent
    },
    {
        path: "profile",
        component: profile_1.ProfileComponent
    },
];
exports.routing = router_1.RouterModule.forRoot(appRoutes);
exports.appRouterProviders = router_1.provideRoutes(appRoutes);
//# sourceMappingURL=app.routing.js.map