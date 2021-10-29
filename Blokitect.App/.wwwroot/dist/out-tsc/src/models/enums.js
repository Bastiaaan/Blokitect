export var Priority;
(function (Priority) {
    Priority[Priority["Low"] = 0] = "Low";
    Priority[Priority["High"] = 1] = "High";
})(Priority || (Priority = {}));
export var ReturnValue;
(function (ReturnValue) {
    ReturnValue[ReturnValue["Int"] = 0] = "Int";
    ReturnValue[ReturnValue["String"] = 1] = "String";
    ReturnValue[ReturnValue["DateTime"] = 2] = "DateTime";
    ReturnValue[ReturnValue["TimeStamp"] = 3] = "TimeStamp";
    ReturnValue[ReturnValue["Decimal"] = 4] = "Decimal";
    ReturnValue[ReturnValue["Bytes"] = 5] = "Bytes";
})(ReturnValue || (ReturnValue = {}));
export var SupplierType;
(function (SupplierType) {
    SupplierType[SupplierType["Accountancy"] = 0] = "Accountancy";
    SupplierType[SupplierType["Engineering"] = 1] = "Engineering";
    SupplierType[SupplierType["IT"] = 2] = "IT";
    SupplierType[SupplierType["Software"] = 3] = "Software";
})(SupplierType || (SupplierType = {}));
export var UserRole;
(function (UserRole) {
    UserRole[UserRole["Admin"] = 0] = "Admin";
    UserRole[UserRole["Customer"] = 1] = "Customer";
    UserRole[UserRole["Supplier"] = 2] = "Supplier";
})(UserRole || (UserRole = {}));
export var TokenProvider;
(function (TokenProvider) {
    TokenProvider[TokenProvider["Admin"] = 0] = "Admin";
    TokenProvider[TokenProvider["Customer"] = 1] = "Customer";
    TokenProvider[TokenProvider["Supplier"] = 2] = "Supplier";
    TokenProvider[TokenProvider["Temporary"] = 3] = "Temporary";
})(TokenProvider || (TokenProvider = {}));
//# sourceMappingURL=enums.js.map