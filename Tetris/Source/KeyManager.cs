namespace Tetris;

class KeyManager
{

    private KeyManager() { }

    private static KeyManager instance = null;

    public static KeyManager Instance
    {

        get
        {

            if (instance == null) instance = new KeyManager();
            return instance;

        }

    }

    private List<Keys> Keys = new List<Keys>();

    public void Add(Keys key) { if (!Keys.Contains(key)) Keys.Add(key); }

    public void Remove(Keys key) { Keys.Remove(key); }

    public bool IsPressed(Keys key, bool OneTime = false)
    {

        bool result = Keys.Contains(key); ;

        if (result && OneTime) Remove(key);

        return result;

    }

}

