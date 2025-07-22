using UnityEngine;

public class Player2Shoot : MonoBehaviour
    {
        public GameObject preFab;
        public Transform bulletTrash; 
        public Transform bulletSpawn;

        private const float Timer = 0.5f; 
        private float _currentTime = 0.5f; 
        private bool _canShoot =  true;

    private void Update()
    {
        TimerMethod();
            
        if (Input.GetKeyDown(KeyCode.Mouse1) && _canShoot)
        {
        GameObject bullet2 = Instantiate(preFab, bulletSpawn.position, Quaternion.identity);
        bullet2.transform.SetParent(bulletTrash);
        _canShoot = false;
        }
    }

    
private void TimerMethod()
{
    if (!_canShoot)
    {
        _currentTime -= Time.deltaTime;

        if (_currentTime < 0)
        {
            _canShoot = true;
            _currentTime = Timer;
        }
    }
}

private void Shoot()
    {
    if (Input.GetKeyDown(KeyCode.Mouse1) && _canShoot)
    {
        GameObject bullet2 = Instantiate(preFab, bulletSpawn.position, Quaternion.identity);
        bullet2.transform.SetParent(bulletTrash);

        _canShoot = false;
        }
    }
    }
    