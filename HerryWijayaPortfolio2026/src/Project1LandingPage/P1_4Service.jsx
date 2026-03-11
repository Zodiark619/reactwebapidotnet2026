export default function P1_4Service({ data }) {
  const services = data.services.map((x) => {
    return (
      <div key={x.title} className="column">
        <div className="box">
          <div className="content">
            <h4 className="title is-5">{x.title}</h4>
            {x.description}
          </div>
        </div>
      </div>
    );
  });
  return (
    <div>
      <section className="section" id="services">
        <div className="section-heading">
          <h3 className="title is-2">Services</h3>
          <h4 className="subtitle is-5">What can I do for you?</h4>
        </div>
        <div className="container">
          <div className="columns is-multiline">{services}</div>
        </div>
      </section>
    </div>
  );
}
