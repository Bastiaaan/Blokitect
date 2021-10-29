import { Service } from './service';
export class AuthService extends Service {
    constructor(api, router) {
        super("auth");
        this.api = api;
        this.router = router;
    }
    login(viewModel) {
        this.addHeader("data", JSON.stringify(viewModel));
        this.api.post(`${this.apiUrl}/login`, this.headers)
            .subscribe((result) => {
            result.success !== false
                ? localStorage.setItem('authToken', null)
                : console.error('wrong login attempt');
            const token = localStorage.getItem('authToken');
            if (token !== null) {
                this.router.navigateByUrl(`dashboard/${token}`);
            }
        });
    }
    register(viewModel) {
        this.addHeader("data", JSON.stringify(viewModel));
        this.api.post(`${this.apiUrl}/register`, this.headers).pipe();
    }
    logout() {
        this.api.post(`${this.apiUrl}/logout`, this.headers).pipe();
        localStorage.removeItem('token');
    }
    isAuthenticated(token) {
        return this.api.post(`${this.apiUrl}/${token}`, this.headers)
            .pipe((result) => {
            var _a;
            return (_a = result.success) !== null && _a !== void 0 ? _a : false;
            //handleError();
        });
    }
    isAuthorized() {
        return false;
    }
}
//# sourceMappingURL=auth.service.js.map