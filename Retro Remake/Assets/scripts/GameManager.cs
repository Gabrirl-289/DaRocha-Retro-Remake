using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public player player;
    
    public ParticleSystem explosion;

    public float respawnTime = 3.0f;
    public float respawnInvulnerabilityTime = 3.0f;

    public int lives = 3;

    public TMPro.TMP_Text scoreText;

    public TMPro.TMP_Text liveText;



    public int score = 0;


    public void AsteroidDestroyed(Asteroid asteroid)
    {
        this.explosion.transform.position = asteroid.transform.position;
        this.explosion.Play();

        if (asteroid.size < 0.75f)
        {
            this.score += 100;
        } else if (asteroid.size < 1.2f)
        {
            score += 50;
        }
        else
        {
            this.score += 25;
        }

    }
    public void PlayerDied()
    {

        this.lives--;

        if (this.lives <= 0)
        {
            GameOver();
        }
        else
        {
            Invoke(nameof(Respawn), this.respawnTime);
        }
        this.explosion.transform.position = this.player.transform.position;
        this.explosion.Play();
    }
    
    private void Respawn()
    {
        this.player.transform.position = Vector3.zero;
        this.player.gameObject.layer = LayerMask.NameToLayer("Ignore Collisions");
        this.player.gameObject.SetActive( true );
        
        Invoke(nameof(TurnOnCollisions), this.respawnInvulnerabilityTime);
    }

    private void TurnOnCollisions()
    {
        this.player.gameObject.layer = LayerMask.NameToLayer("Player");
    }

    private void GameOver()
    {
        this.lives = 3;
        this.score = 0;
       
        Invoke(nameof(Respawn), this.respawnTime);
        SceneManager.LoadScene("gameover");
    }
    void Update()
    {
        scoreText.SetText("Score: " + score.ToString());
        liveText.SetText("Lives: " + lives.ToString());
    }

}