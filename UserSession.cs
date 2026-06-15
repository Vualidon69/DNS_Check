using System;
using System.Collections.Generic;

namespace DNS_DoAn
{
    public static class UserSession
    {
        public static string CurrentUser { get; private set; } = null;
        private static Dictionary<string, string> _users = new Dictionary<string, string>()
        {
            { "admin", "123" }
        };
        private static Dictionary<string, List<string>> _searchHistory = new Dictionary<string, List<string>>();

        public static bool IsLoggedIn => !string.IsNullOrEmpty(CurrentUser);

        //ĐĂNG NHẬP
        public static bool Login(string username, string password)
        {
            // Kiểm tra tên đăng nhập và mật khẩu
            if (_users.ContainsKey(username) && _users[username] == password)
            {
                CurrentUser = username;
                if (!_searchHistory.ContainsKey(username))
                {
                    _searchHistory[username] = new List<string>();
                }
                return true;
            }
            return false;
        }

        //ĐĂNG KÝ
        public static bool Register(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return false;

            if (_users.ContainsKey(username))
            {
                return false; 
            }
            _users.Add(username, password);
            _searchHistory.Add(username, new List<string>());

            return true;
        }

        public static void Logout() => CurrentUser = null;

        public static void AddHistory(string domain, string result)
        {
            if (IsLoggedIn)
            {
                if (!_searchHistory.ContainsKey(CurrentUser))
                {
                    _searchHistory[CurrentUser] = new List<string>();
                }

                string log = $"[{DateTime.Now:HH:mm:ss}] {domain} => {result}";
                _searchHistory[CurrentUser].Add(log);
            }
        }

        public static List<string> GetMyHistory()
        {
            if (IsLoggedIn && _searchHistory.ContainsKey(CurrentUser)) return _searchHistory[CurrentUser];
            return new List<string>();
        }
    }
}