export default function P1_2Header({ data }) {
  return (
    <div>
      <section
        className="hero is-link is-fullheight is-fullheight-with-navbar"
        style={{
          backgroundImage: `url(/Project1LandingPage/${data.heroimage})`,
          backgroundSize: "full",
          backgroundPosition: "center",
        }}
      >
        <div className="hero-body">
          <div className="container">
            Hello! I am
            <h1 className="title is-1">{data.name}</h1>
            <h2 className="subtitle is-3">{data.position1}</h2>
          </div>
        </div>
      </section>
    </div>
  );
}
