export default function P1_6Portfolio({ data }) {
  const portfolios = data.portfolio.map((x) => {
    return (
      <div key={x.title} className="card">
        <header className="card-header">
          <p className="card-header-title">
            <span>{x.title}</span>
          </p>
        </header>
        <div className="card-content">
          <figure className="image">
            <img src={`/Project1LandingPage/${x.previewimage}`} alt={x.title} />
          </figure>
        </div>
        <footer className="card-footer">
          <a href={x.url} className="card-footer-item" target="_blank">
            Source Code
          </a>
        </footer>
      </div>
    );
  });

  return (
    <div>
      <section className="section" id="portfolio">
        <div className="container">
          <div className="section-heading">
            <h3 className="title is-2">Portfolio</h3>
            <h4 className="subtitle is-5">My latest works</h4>
          </div>
          <br />

          <div className="container portfolio-container">
            <div className="columns">
              <div className="column is-12">{portfolios}</div>
            </div>
          </div>
        </div>
      </section>
    </div>
  );
}
