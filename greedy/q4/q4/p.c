void solve()
{
    ll n,m,k;
    cin >> n >> m >> k;
    string s;
    cin >> s;
    ll i= -1;
    while(i<n)
    {
        while(i>=0 && i<n && s[i] == 'W')
        {
            i++;
            k--;
            if(k<0)
            {
                cout << "NO" << nl;
                return;
            }
        }
        if(s[i]=='C')
        {
            cout << "NO" <, nl;
            return;
        }
        bool f= false;
        for(ll j=m; j >= 1 ; j--)
    
    {
        if(i+j >= n)
        {
            cout << "YES" << nl;
        }
        if(s[i+j]=='L')
        {
            i += j;
            f = true;
            break;
        }
    }
    if(f)continue;
     for(ll j=m; j >= 1 ; j--)
    
    {
        if(s[i+j]=='W')
        {
            i += j;
            f = true;
            break;
        }
    }
    }
    if(f)
    {
        continue;
    }
                cout << "NO" << nl;
                return;

}