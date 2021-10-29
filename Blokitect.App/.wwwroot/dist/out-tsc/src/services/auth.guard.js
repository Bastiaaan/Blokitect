export class AuthGuard {
    constructor(router, authService) {
        this.router = router;
        this.authService = authService;
    }
    canActivate() {
        if (this.authService.isAuthenticated(localStorage.getItem('authToken'))) {
            return true;
        }
        return false;
    }
}
//# sourceMappingURL=auth.guard.js.map