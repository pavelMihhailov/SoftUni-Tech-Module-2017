<?php

/* base.html.twig */
class __TwigTemplate_296371a8e1b4d0e0ed7d34d2e53ee536d15b2a8cf0bc93a289eecf8c4e1ee19d extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'header' => array($this, 'block_header'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
            'javascripts' => array($this, 'block_javascripts'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_cee73f2c7d0e1ce31dd560711606dbedd812d65dc6f7626edb37da5c616f7189 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_cee73f2c7d0e1ce31dd560711606dbedd812d65dc6f7626edb37da5c616f7189->enter($__internal_cee73f2c7d0e1ce31dd560711606dbedd812d65dc6f7626edb37da5c616f7189_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>";
        // line 11
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 12
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 16
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 19
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">

";
        // line 21
        $this->displayBlock('header', $context, $blocks);
        // line 39
        echo "
<div class=\"container body-container\">
    ";
        // line 41
        $this->displayBlock('body', $context, $blocks);
        // line 48
        echo "</div>


";
        // line 51
        $this->displayBlock('javascripts', $context, $blocks);
        // line 57
        echo "
</body>
</html>
";
        
        $__internal_cee73f2c7d0e1ce31dd560711606dbedd812d65dc6f7626edb37da5c616f7189->leave($__internal_cee73f2c7d0e1ce31dd560711606dbedd812d65dc6f7626edb37da5c616f7189_prof);

    }

    // line 11
    public function block_title($context, array $blocks = array())
    {
        $__internal_17a115c13b7b62b9af28a89d1171257d2651237319eea60aa7ce42dfb0a01037 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_17a115c13b7b62b9af28a89d1171257d2651237319eea60aa7ce42dfb0a01037->enter($__internal_17a115c13b7b62b9af28a89d1171257d2651237319eea60aa7ce42dfb0a01037_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Calculator";
        
        $__internal_17a115c13b7b62b9af28a89d1171257d2651237319eea60aa7ce42dfb0a01037->leave($__internal_17a115c13b7b62b9af28a89d1171257d2651237319eea60aa7ce42dfb0a01037_prof);

    }

    // line 12
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_8becb1c2f63c34c18cc713a46c1a33bfb4fbd9aff57d17a20dc74bf5541275f9 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8becb1c2f63c34c18cc713a46c1a33bfb4fbd9aff57d17a20dc74bf5541275f9->enter($__internal_8becb1c2f63c34c18cc713a46c1a33bfb4fbd9aff57d17a20dc74bf5541275f9_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 13
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 14
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/bootstrap-datetimepicker.min.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_8becb1c2f63c34c18cc713a46c1a33bfb4fbd9aff57d17a20dc74bf5541275f9->leave($__internal_8becb1c2f63c34c18cc713a46c1a33bfb4fbd9aff57d17a20dc74bf5541275f9_prof);

    }

    // line 19
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_3b3530d5baa8927b8f286accffab62499839bd8e8abce1509dd3c979b68f4d12 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_3b3530d5baa8927b8f286accffab62499839bd8e8abce1509dd3c979b68f4d12->enter($__internal_3b3530d5baa8927b8f286accffab62499839bd8e8abce1509dd3c979b68f4d12_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_3b3530d5baa8927b8f286accffab62499839bd8e8abce1509dd3c979b68f4d12->leave($__internal_3b3530d5baa8927b8f286accffab62499839bd8e8abce1509dd3c979b68f4d12_prof);

    }

    // line 21
    public function block_header($context, array $blocks = array())
    {
        $__internal_30c66e4f7a7ff84f812485132987f2471552767f163915ce94f5ec9b47ec2c34 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_30c66e4f7a7ff84f812485132987f2471552767f163915ce94f5ec9b47ec2c34->enter($__internal_30c66e4f7a7ff84f812485132987f2471552767f163915ce94f5ec9b47ec2c34_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "header"));

        // line 22
        echo "    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"";
        // line 26
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("index");
        echo "\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
";
        
        $__internal_30c66e4f7a7ff84f812485132987f2471552767f163915ce94f5ec9b47ec2c34->leave($__internal_30c66e4f7a7ff84f812485132987f2471552767f163915ce94f5ec9b47ec2c34_prof);

    }

    // line 41
    public function block_body($context, array $blocks = array())
    {
        $__internal_aa8e33e575b40afa73b1b7a4a215377d48edf78a32915436ff38821210c373ae = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_aa8e33e575b40afa73b1b7a4a215377d48edf78a32915436ff38821210c373ae->enter($__internal_aa8e33e575b40afa73b1b7a4a215377d48edf78a32915436ff38821210c373ae_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 42
        echo "        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                ";
        // line 44
        $this->displayBlock('main', $context, $blocks);
        // line 45
        echo "            </div>
        </div>
    ";
        
        $__internal_aa8e33e575b40afa73b1b7a4a215377d48edf78a32915436ff38821210c373ae->leave($__internal_aa8e33e575b40afa73b1b7a4a215377d48edf78a32915436ff38821210c373ae_prof);

    }

    // line 44
    public function block_main($context, array $blocks = array())
    {
        $__internal_c51ad09600b0347a505c1328b0d5df80faac221d37c1d535a1bf0276e307cdf4 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c51ad09600b0347a505c1328b0d5df80faac221d37c1d535a1bf0276e307cdf4->enter($__internal_c51ad09600b0347a505c1328b0d5df80faac221d37c1d535a1bf0276e307cdf4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_c51ad09600b0347a505c1328b0d5df80faac221d37c1d535a1bf0276e307cdf4->leave($__internal_c51ad09600b0347a505c1328b0d5df80faac221d37c1d535a1bf0276e307cdf4_prof);

    }

    // line 51
    public function block_javascripts($context, array $blocks = array())
    {
        $__internal_14adbbd3ddb2c4b109e4006d3ccf480212ab78cf0e692c398b57767df216cdbc = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_14adbbd3ddb2c4b109e4006d3ccf480212ab78cf0e692c398b57767df216cdbc->enter($__internal_14adbbd3ddb2c4b109e4006d3ccf480212ab78cf0e692c398b57767df216cdbc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "javascripts"));

        // line 52
        echo "    <script src=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/jquery-2.2.4.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 53
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/moment.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 54
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 55
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap-datetimepicker.min.js"), "html", null, true);
        echo "\"></script>
";
        
        $__internal_14adbbd3ddb2c4b109e4006d3ccf480212ab78cf0e692c398b57767df216cdbc->leave($__internal_14adbbd3ddb2c4b109e4006d3ccf480212ab78cf0e692c398b57767df216cdbc_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  205 => 55,  201 => 54,  197 => 53,  192 => 52,  186 => 51,  175 => 44,  166 => 45,  164 => 44,  160 => 42,  154 => 41,  134 => 26,  128 => 22,  122 => 21,  111 => 19,  102 => 14,  97 => 13,  91 => 12,  79 => 11,  69 => 57,  67 => 51,  62 => 48,  60 => 41,  56 => 39,  54 => 21,  49 => 19,  42 => 16,  40 => 12,  36 => 11,  29 => 6,);
    }

    public function getSource()
    {
        return "{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>{% block title %}Calculator{% endblock %}</title>
    {% block stylesheets %}
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/bootstrap-datetimepicker.min.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">

{% block header %}
    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"{{ path('index') }}\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
{% endblock %}

<div class=\"container body-container\">
    {% block body %}
        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                {% block main %}{% endblock %}
            </div>
        </div>
    {% endblock %}
</div>


{% block javascripts %}
    <script src=\"{{ asset('js/jquery-2.2.4.min.js') }}\"></script>
    <script src=\"{{ asset('js/moment.min.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap-datetimepicker.min.js') }}\"></script>
{% endblock %}

</body>
</html>
";
    }
}
