window.localStorageInterop = {
    saveUser: function (key, userJson) {
        localStorage.setItem(key, userJson);
    },
    getUser: function (key) {
        return localStorage.getItem(key);
    },
    saveEvent: function (key, userJson) {
        localStorage.setItem(key, userJson);
    },
    getEvent: function (key) {
        return localStorage.getItem(key);
    }
};
