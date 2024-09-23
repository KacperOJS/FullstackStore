
import '../styles/About.css';

const About = () => {
  return (
    <div className="about-container">
      <h1>O Nas</h1>
      <p className="about-intro">
        Witamy w FPS-Shop, Twoim ulubionym miejscu na zakupy z bronią wirtualną i akcesoriami! Nasza pasja do gier i technologii skłoniła nas do stworzenia platformy, która dostarcza najwyższej jakości produkty dla entuzjastów gier FPS na całym świecie.
      </p>

      <section className="about-our-mission">
        <h2>Nasza Misja</h2>
        <p>
          W FPS-Shop dążymy do zapewnienia graczom doskonałych doświadczeń. Naszym celem jest oferowanie najnowszych produktów, które zwiększą Twoją wydajność w grze. Zawsze szukamy innowacji i staramy się być na bieżąco z najnowszymi trendami w branży.
        </p>
      </section>

      <section className="about-our-history">
        <h2>Nasza Historia</h2>
        <p>
          FPS-Shop powstał w 2020 roku z pasji do gier. Zaczynaliśmy jako mały startup, a dzięki naszym zadowolonym klientom szybko zyskaliśmy uznanie w branży. Dziś jesteśmy jednym z wiodących dostawców sprzętu gamingowego, z tysiącami zadowolonych klientów na całym świecie.
        </p>
        <p>
          Nasza podróż nie byłaby możliwa bez wsparcia naszej społeczności. Dziękujemy, że jesteś częścią naszej historii!
        </p>
      </section>

      <section className="about-our-team">
        <h2>Nasz Zespół</h2>
        <p>
          Nasz zespół składa się z pasjonatów gier, którzy łączą wiedzę techniczną z doświadczeniem w branży. Pracujemy razem, aby dostarczać Ci najlepsze produkty i usługi. Jesteśmy tu, aby służyć Ci pomocą w każdej sytuacji.
        </p>
        <ul className="team-members">
          <li>
            <h3>Jan Kowalski</h3>
            <p>CEO i współzałożyciel. Pasjonat gier FPS z ponad 10-letnim doświadczeniem.</p>
          </li>
          <li>
            <h3>Anna Nowak</h3>
            <p>Dyrektor marketingu. Specjalizuje się w strategiach społecznościowych i kampaniach reklamowych.</p>
          </li>
          <li>
            <h3>Krzysztof Wiśniewski</h3>
            <p>Główny inżynier. Odpowiedzialny za rozwój technologii i platformy FPS-Shop.</p>
          </li>
          <li>
            <h3>Maria Zielińska</h3>
            <p>Obsługa klienta. Zawsze gotowa, aby pomóc Ci z pytaniami i problemami.</p>
          </li>
        </ul>
      </section>

      <section className="about-what-we-offer">
        <h2>Co Oferujemy</h2>
        <p>
          W FPS-Shop oferujemy szeroką gamę produktów, w tym:
        </p>
        <ul>
          <li>Sprzęt do gier: myszy, klawiatury, słuchawki i więcej.</li>
          <li>Akcesoria do gier: podkładki pod mysz, uchwyty i statywy.</li>
          <li>Gry wideo: najnowsze tytuły oraz klasyki.</li>
          <li>Sprzęt VR: przenieś się do wirtualnego świata!</li>
        </ul>
      </section>

      <section className="about-our-commitment">
        <h2>Nasze Zobowiązanie</h2>
        <p>
          Jesteśmy zobowiązani do oferowania produktów najwyższej jakości i doskonałej obsługi klienta. Wierzymy w budowanie długotrwałych relacji z naszymi klientami i społecznością. Nasza strategia polega na ciągłym doskonaleniu naszych usług i produktów, aby spełniały Twoje oczekiwania.
        </p>
      </section>

      <section className="about-get-in-touch">
        <h2>Skontaktuj się z Nami</h2>
        <p>
          Chcesz się z nami skontaktować? Napisz do nas na adres: <a href="mailto:kontakt@fps-shop.com">kontakt@fps-shop.com</a>
        </p>
      </section>
    </div>
  );
}

export default About;
