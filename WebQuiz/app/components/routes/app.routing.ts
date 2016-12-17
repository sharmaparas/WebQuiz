import { provideRoutes, Routes, RouterModule } from "@angular/router";
import { DefaultComponent } from "../default";
import { ProfileComponent } from "../profile";
import { UserProfileComponent } from "../user";

const appRoutes: Routes = [
    {
        path: "",
        component: DefaultComponent
    },
    {
        path: "profile",
        component: ProfileComponent
    },
    {
        path: "user",
        component: UserProfileComponent
    },
];

export const routing = RouterModule.forRoot(appRoutes);
export const appRouterProviders = provideRoutes(appRoutes);
